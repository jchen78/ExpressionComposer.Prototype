using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class MemberAccessNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.MemberAccess;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            MemberExpression
                left = (MemberExpression)leftExpression,
                right = (MemberExpression)rightExpression;

            if (left.Member != right.Member)
                return ComparisonResult.NotEqual;

            if (left.Expression == null)
                return ComparisonResult.PartiallyEqual;

            return childrenComparer.Compare(left.Expression, right.Expression);
        }
    }
}