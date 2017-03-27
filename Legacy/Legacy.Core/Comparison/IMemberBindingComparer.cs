using System.Linq.Expressions;

namespace Legacy.Core.Comparison
{
    public interface IMemberBindingComparer
    {
        ComparisonResult AreEqual(IComparisonEffector subtreeComparer, MemberAssignment left, MemberAssignment right);

        ComparisonResult AreEqual(IComparisonEffector subtreeComparer, MemberListBinding left, MemberListBinding right);

        ComparisonResult AreEqual(IComparisonEffector subtreeComparer, MemberMemberBinding left, MemberMemberBinding right);
    }
}
