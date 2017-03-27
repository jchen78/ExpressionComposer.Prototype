using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class RuntimeVariablesNodeSequentialComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.RuntimeVariables;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            RuntimeVariablesExpression
                left = (RuntimeVariablesExpression)leftExpression,
                right = (RuntimeVariablesExpression)rightExpression;

            if (left.Variables.Count != right.Variables.Count)
                return ComparisonResult.NotEqual;

            for (int i = 0; i < left.Variables.Count; i++)
                if (childrenComparer.Compare(left.Variables[i], right.Variables[i]) == ComparisonResult.NotEqual)
                    return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }
    }
}
