using System.Collections.Generic;
using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class SwitchCaseComparer : ISwitchCaseComparer
    {
        public bool AreEqual(IComparisonEffector subtreeComparer, SwitchCase leftCase, SwitchCase rightCase)
        {
            if (!AreTestValuesEquivalent(subtreeComparer, leftCase, rightCase))
                return false;

            return subtreeComparer.Compare(leftCase.Body, rightCase.Body) != ComparisonResult.NotEqual;
        }

        private bool AreTestValuesEquivalent(IComparisonEffector subtreeComparer, SwitchCase leftCase, SwitchCase rightCase)
        {
            if (leftCase.TestValues.Count != rightCase.TestValues.Count)
                return false;

            bool correspondingTestIsFound;
            var rightTests = new List<Expression>(rightCase.TestValues);
            foreach (var leftTest in leftCase.TestValues) {
                correspondingTestIsFound = false;
                for (int i = 0; i < rightTests.Count; i++) {
                    if (subtreeComparer.Compare(leftTest, rightTests[i]) != ComparisonResult.NotEqual){
                        rightTests.RemoveAt(i);
                        correspondingTestIsFound = true;
                        break;
                    }
                }

                if (!correspondingTestIsFound)
                    return false;
            }

            return true;
        }
    }
}