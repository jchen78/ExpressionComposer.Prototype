using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class IndexNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Index;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            IndexExpression
                left = (IndexExpression)leftExpression,
                right = (IndexExpression)rightExpression;

            if (left.Indexer != right.Indexer || childrenComparer.Compare(left.Object, right.Object) == ComparisonResult.NotEqual)
                return ComparisonResult.NotEqual;

            for (int i = 0; i < left.Arguments.Count; i++)
                if (childrenComparer.Compare(left.Arguments[i], right.Arguments[i]) == ComparisonResult.NotEqual)
                    return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }
    }
}
