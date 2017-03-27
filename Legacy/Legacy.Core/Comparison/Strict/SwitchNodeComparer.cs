using System.Collections.Generic;
using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class SwitchNodeComparer : INodeComparerForType
    {
        private ISwitchCaseComparer switchCaseComparer;

        public SwitchNodeComparer(ISwitchCaseComparer switchCaseComparer)
        {
            this.switchCaseComparer = switchCaseComparer;
        }

        public ExpressionType NodeType => ExpressionType.Switch;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            SwitchExpression
                left = (SwitchExpression)leftExpression,
                right = (SwitchExpression)rightExpression;

            if (left.Cases.Count != right.Cases.Count ||
                !DefaultBodiesAreEqual(childrenComparer, left, right) ||
                !AreCasesEquivalent(childrenComparer, left.Cases, right.Cases))
                return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }

        private static bool DefaultBodiesAreEqual(IComparisonEffector childrenComparer, SwitchExpression left, SwitchExpression right)
        {
            if (left.DefaultBody == null)
                return right.DefaultBody == null;

            return childrenComparer.Compare(left.DefaultBody, right.DefaultBody) != ComparisonResult.NotEqual;
        }

        private bool AreCasesEquivalent(IComparisonEffector childrenComparer, IEnumerable<SwitchCase> leftCases, IEnumerable<SwitchCase> rightCases)
        {
            var remainingRightCases = new List<SwitchCase>(rightCases);
            bool isCorrespondingCaseFound;
            foreach (var left in leftCases) {
                isCorrespondingCaseFound = false;
                for (int i = 0; i < remainingRightCases.Count; i++)
                    if (switchCaseComparer.AreEqual(childrenComparer, left, remainingRightCases[i])) {
                        remainingRightCases.RemoveAt(i);
                        isCorrespondingCaseFound = true;
                        break;
                    }

                if (!isCorrespondingCaseFound)
                    return false;
            }

            return true;
        }
    }
}