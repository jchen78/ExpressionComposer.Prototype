using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class NodeExpressionTypeComparer : INodeComparer
    {
        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            return leftExpression.NodeType == rightExpression.NodeType ? ComparisonResult.PartiallyEqual : ComparisonResult.NotEqual;
        }
    }
}