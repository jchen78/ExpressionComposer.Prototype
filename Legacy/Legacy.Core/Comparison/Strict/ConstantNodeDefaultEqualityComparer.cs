using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class ConstantNodeDefaultEqualityComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Constant;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            var left = (ConstantExpression)leftExpression;
            var right = (ConstantExpression)rightExpression;
            if (left.Value == null)
                return right.Value == null ? ComparisonResult.Equal : ComparisonResult.NotEqual;

            return left.Value.Equals(right.Value) ? ComparisonResult.PartiallyEqual : ComparisonResult.NotEqual;
        }
    }
}