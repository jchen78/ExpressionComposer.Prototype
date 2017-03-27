using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Legacy.Core.Reduction
{
    public class TransparentIdentifierRemover : IManipulationUnit
    {
        private IManipulationUnit sourceUnit;

        public TransparentIdentifierRemover(IManipulationUnit sourceUnit) {
            this.sourceUnit = sourceUnit;
        }

        public ReadOnlyCollection<ParameterExpression> Parameters {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ManipulationType UnitType => sourceUnit.UnitType;

        public Expression Extract(ReadOnlyCollection<ParameterExpression> uniformParameters) {
            throw new NotImplementedException();
        }

        public LambdaExpression ExtractToLambda() {
            return (LambdaExpression)(new TransparentExtractor().Visit(sourceUnit.ExtractToLambda()));
        }

        private class TransparentExtractor : ExpressionVisitor
        {
            private static readonly Type compilerGeneratedAttributeType = typeof(CompilerGeneratedAttribute);

            private Dictionary<Type, Dictionary<MemberInfo, Expression>> equivalentExpressions = new Dictionary<Type, Dictionary<MemberInfo, Expression>>();

            protected override Expression VisitMember(MemberExpression node) {
                if (node.Expression != null && IsAnonymousType(node.Expression.Type)) {
                    Dictionary<MemberInfo, Expression> currentEquivalences;
                    if (equivalentExpressions.TryGetValue(node.Expression.Type, out currentEquivalences))
                        return currentEquivalences[node.Member];

                    base.Visit(node.Expression);
                    if (equivalentExpressions.TryGetValue(node.Expression.Type, out currentEquivalences))
                        return currentEquivalences[node.Member];
                }

                return base.VisitMember(node);
            }

            protected override Expression VisitNew(NewExpression node) {
                if (node.Members != null && node.Arguments.Count == node.Members.Count && !equivalentExpressions.ContainsKey(node.Type) && IsAnonymousType(node.Type)) {
                    var currentEquivalences = new Dictionary<MemberInfo, Expression>();
                    for (int i = 0; i < node.Members.Count; i++)
                        currentEquivalences.Add(node.Members[i], node.Arguments[i]);

                    equivalentExpressions.Add(node.Type, currentEquivalences);
                }

                return base.VisitNew(node);
            }

            private bool IsAnonymousType(Type type) {
                foreach (var attribute in type.GetTypeInfo().CustomAttributes)
                    if (attribute.AttributeType == compilerGeneratedAttributeType)
                        return true;

                return false;
            }
        }
    }
}
