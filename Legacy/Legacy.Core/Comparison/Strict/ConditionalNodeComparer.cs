using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class ConditionalNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Conditional;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            var left = (ConditionalExpression)leftExpression;
            var right = (ConditionalExpression)rightExpression;
            if (childrenComparer.Compare(left.Test, right.Test) == ComparisonResult.NotEqual
                || childrenComparer.Compare(left.IfTrue, right.IfTrue) == ComparisonResult.NotEqual
                || childrenComparer.Compare(left.IfFalse, right.IfFalse) == ComparisonResult.NotEqual)
                return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }
    }
}