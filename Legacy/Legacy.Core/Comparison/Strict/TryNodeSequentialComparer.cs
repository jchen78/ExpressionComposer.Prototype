using System.Collections.Generic;
using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class TryNodeSequentialComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Try;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            TryExpression
                left = (TryExpression)leftExpression,
                right = (TryExpression)rightExpression;

            if (!AreHandlersEqual(childrenComparer, left.Handlers, right.Handlers)
                || childrenComparer.Compare(left.Body, right.Body) == ComparisonResult.NotEqual
                || !AreOptionalExpressionsEqual(childrenComparer, left.Finally, right.Finally)
                || !AreOptionalExpressionsEqual(childrenComparer, left.Fault, right.Fault))
                return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }

        private bool AreHandlersEqual(IComparisonEffector subtreeComparer, IList<CatchBlock> leftHandlers, IList<CatchBlock> rightHandlers)
        {
            if (leftHandlers.Count != rightHandlers.Count)
                return false;

            IComparisonEffector catchblockComparer;
            for (int i = 0; i < leftHandlers.Count; i++) {
                CatchBlock
                    left = leftHandlers[i],
                    right = rightHandlers[i];

                catchblockComparer = subtreeComparer.WithPairedParameters(left.Variable, right.Variable);
                if (left.Test != right.Test
                    || !AreOptionalExpressionsEqual(catchblockComparer, left.Filter, right.Filter)
                    || catchblockComparer.Compare(left.Body, right.Body) == ComparisonResult.NotEqual)
                    return false;
            }

            return true;
        }

        private bool AreOptionalExpressionsEqual(IComparisonEffector subtreeComparer, Expression left, Expression right)
        {
            if (left == null)
                return right == null;

            if (right == null)
                return false;

            return subtreeComparer.Compare(left, right) != ComparisonResult.NotEqual;
        }
    }
}