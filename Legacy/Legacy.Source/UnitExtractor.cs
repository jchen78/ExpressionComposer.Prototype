using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Legacy.Core;

namespace Legacy.Source
{
    public class UnitExtractor
    {
        private LambdaExpression original;

        public UnitExtractor(LambdaExpression original) {
            this.original = original;
        }

        public IManipulationUnit Extract() {
            var parser = new ExpressionParser();
            parser.Visit(original.Body);
            return parser.Unit ?? new TrivialUnit(parser.InnerLambda ?? original);
        }

        private class ExpressionParser : ExpressionVisitor
        {
            private static readonly Type sourceClass = typeof(ExpressionSource);

            public LambdaExpression InnerLambda { get; private set; } = null;
            public IManipulationUnit Unit { get; private set; } = null;

            protected override Expression VisitLambda<T>(Expression<T> node) {
                InnerLambda = InnerLambda ?? node;
                return base.VisitLambda(node);
            }

            protected override Expression VisitMethodCall(MethodCallExpression node) {
                if (Unit == null && node.Method.DeclaringType == sourceClass)
                    Unit = ReconstructUnitFromSourceMethod(node);

                return base.VisitMethodCall(node);
            }

            private IManipulationUnit ReconstructUnitFromSourceMethod(MethodCallExpression node) {
                switch (node.Method.Name) {
                    case "Apply":
                        var source = ReconstructUnit(node.Arguments[0]);
                        var applicationLambda = (LambdaExpression)((UnaryExpression)node.Arguments[1]).Operand;

                        return ExpressionSource.Apply(source, applicationLambda);

                    case "SelectMany":
                        var left = ReconstructUnit(node.Arguments[0]);

                        InnerLambda = null;
                        Visit(((LambdaExpression)((UnaryExpression)node.Arguments[1]).Operand).Body);
                        var right = new TrivialUnit(InnerLambda);

                        var compositionFunction = (LambdaExpression)((UnaryExpression)node.Arguments[2]).Operand;

                        return ExpressionSource.SelectMany(left, right, compositionFunction);

                    case "ToUnit":
                        InnerLambda = null;
                        Visit(node.Arguments[0]);
                        return new TrivialUnit(InnerLambda);

                    default:
                        throw new NotImplementedException();
                }
            }

            private IManipulationUnit ReconstructUnit(Expression node) {
                if (node.NodeType == ExpressionType.Call) {
                    var methodNode = (MethodCallExpression)node;
                    if (methodNode.Method.DeclaringType == sourceClass)
                        return ReconstructUnitFromSourceMethod(methodNode);
                }

                InnerLambda = null;
                Visit(node);
                return new TrivialUnit(InnerLambda);
            }
        }
    }
}
