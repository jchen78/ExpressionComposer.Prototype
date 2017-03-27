using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Legacy.Core.Reduction
{
    public class LocalInvoker : IManipulationUnit
    {
        private Expression<Func<long>> original;
        private IManipulationUnit sourceUnit;

        public LocalInvoker(IManipulationUnit sourceUnit)
        {
            this.sourceUnit = sourceUnit;
        }

        public ReadOnlyCollection<ParameterExpression> Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ManipulationType UnitType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Expression Extract(ReadOnlyCollection<ParameterExpression> uniformParameters)
        {
            throw new NotImplementedException();
        }

        public LambdaExpression ExtractToLambda()
        {
            // TODO
            /*
            This pattern causes double-visitation: it first extracts the children (causing one visit),
            then re-parses for tree reduction.

                -> Inject a "Visitor"; it is up to specific IManipulationUnits to know how to use the visitor (re-test!)
                -> Show that the performance impact of this heavy, ugly, bloated double-visit is, against all expectations, trivial (!?)
            */
            return (LambdaExpression)new ConstantPropagator().Visit(sourceUnit.ExtractToLambda());
        }

        private class ConstantPropagator : ExpressionVisitor
        {
            private bool _isDirty = false;
            private object _currentSubtree = null;

            protected override Expression VisitMember(MemberExpression node)
            {
                return PropagateConstant(node);
            }

            private object getSubtreeValue(Expression subtree) => Expression.Lambda(subtree).Compile().DynamicInvoke();

            private Expression PropagateConstant(Expression subtree) => Expression.Constant(Expression.Lambda(subtree).Compile().DynamicInvoke());
        }
    }
}
