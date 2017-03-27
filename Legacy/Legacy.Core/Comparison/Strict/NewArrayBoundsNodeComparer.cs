using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class NewArrayBoundsNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.NewArrayBounds;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            NewArrayExpression
                left = (NewArrayExpression)leftExpression,
                right = (NewArrayExpression)rightExpression;

            if (left.Expressions.Count != right.Expressions.Count)
                return ComparisonResult.NotEqual;

            for (int i = 0; i < left.Expressions.Count; i++)
                if (childrenComparer.Compare(left.Expressions[i], right.Expressions[i]) == ComparisonResult.NotEqual)
                    return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }
    }
}