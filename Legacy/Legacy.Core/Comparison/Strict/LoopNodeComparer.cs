using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class LoopNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Loop;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            LoopExpression
                left = (LoopExpression)leftExpression,
                right = (LoopExpression)rightExpression;

            if (!childrenComparer.AreLabelTargetsPaired(left.BreakLabel, right.BreakLabel) || !childrenComparer.AreLabelTargetsPaired(left.ContinueLabel, right.ContinueLabel))
                return ComparisonResult.NotEqual;

            return childrenComparer.Compare(((LoopExpression)leftExpression).Body, ((LoopExpression)rightExpression).Body);
        }
    }
}