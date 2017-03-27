using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class InvokeNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Invoke;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            InvocationExpression
                left = (InvocationExpression)leftExpression,
                right = (InvocationExpression)rightExpression;

            if (left.Arguments.Count != right.Arguments.Count)
                return ComparisonResult.NotEqual;

            for (int i = 0; i < left.Arguments.Count; i++)
                if (childrenComparer.Compare(left.Arguments[i], right.Arguments[i]) == ComparisonResult.NotEqual)
                    return ComparisonResult.NotEqual;

            return childrenComparer.Compare(left.Expression, right.Expression);
        }
    }
}