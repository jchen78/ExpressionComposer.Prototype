using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class NodeClrTypeComparer : INodeComparer
    {
        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            return leftExpression.Type == rightExpression.Type ? ComparisonResult.PartiallyEqual : ComparisonResult.NotEqual;
        }
    }
}