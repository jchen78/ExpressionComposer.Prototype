using System.Linq.Expressions;

namespace Legacy.Core.Comparison
{
    public interface ISwitchCaseComparer
    {
        bool AreEqual(IComparisonEffector subtreeComparer, SwitchCase leftCase, SwitchCase rightCase);
    }
}
