using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class GotoNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Goto;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            GotoExpression
                left = (GotoExpression)leftExpression,
                right = (GotoExpression)rightExpression;

            if (!childrenComparer.AreLabelTargetsPaired(left.Target, right.Target))
                return ComparisonResult.NotEqual;

            if (left.Value == null)
                return right.Value == null ? ComparisonResult.PartiallyEqual : ComparisonResult.NotEqual;
            else if (right.Value == null)
                return ComparisonResult.NotEqual;

            return childrenComparer.Compare(left.Value, right.Value);
        }
    }
}