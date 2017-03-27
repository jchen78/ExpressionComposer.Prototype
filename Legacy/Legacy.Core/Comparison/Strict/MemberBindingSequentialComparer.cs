using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class MemberBindingSequentialComparer : IMemberBindingComparer
    {
        public ComparisonResult AreEqual(IComparisonEffector subtreeComparer, MemberAssignment left, MemberAssignment right)
        {
            if (left.Member != right.Member || subtreeComparer.Compare(left.Expression, right.Expression) == ComparisonResult.NotEqual)
                return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }

        public ComparisonResult AreEqual(IComparisonEffector subtreeComparer, MemberListBinding left, MemberListBinding right)
        {
            if (left.Member != right.Member || !AreListItemsEqual(subtreeComparer, left, right))
                return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }

        public ComparisonResult AreEqual(IComparisonEffector subtreeComparer, MemberMemberBinding left, MemberMemberBinding right)
        {
            if (left.Bindings.Count != right.Bindings.Count)
                return ComparisonResult.NotEqual;

            for (int i = 0; i < left.Bindings.Count; i++)
                if (!AreBindingsEqual(subtreeComparer, left.Bindings[i], right.Bindings[i]))
                    return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }

        private bool AreListItemsEqual(IComparisonEffector subtreeComparer, MemberListBinding left, MemberListBinding right)
        {
            if (left.Initializers.Count != right.Initializers.Count)
                return false;

            for (int i = 0; i < left.Initializers.Count; i++)
                if (!IsInitializerSame(subtreeComparer, left.Initializers[i], right.Initializers[i]))
                    return false;

            return true;
        }

        private bool IsInitializerSame(IComparisonEffector subtreeComparer, ElementInit left, ElementInit right)
        {
            if (left.AddMethod != right.AddMethod || left.Arguments.Count != right.Arguments.Count)
                return false;

            for (int i = 0; i < left.Arguments.Count; i++)
                if (subtreeComparer.Compare(left.Arguments[i], right.Arguments[i]) == ComparisonResult.NotEqual)
                    return false;

            return true;
        }

        private bool AreBindingsEqual(IComparisonEffector subtreeComparer, MemberBinding left, MemberBinding right)
        {
            var comparisonResult = ComparisonResult.PartiallyEqual;
            switch (left.BindingType) {
                case MemberBindingType.Assignment:
                    comparisonResult = AreEqual(subtreeComparer, (MemberAssignment)left, (MemberAssignment)right);
                    break;
                case MemberBindingType.ListBinding:
                    comparisonResult = AreEqual(subtreeComparer, (MemberListBinding)left, (MemberListBinding)right);
                    break;
                case MemberBindingType.MemberBinding:
                    comparisonResult = AreEqual(subtreeComparer, (MemberMemberBinding)left, (MemberMemberBinding)right);
                    break;
            }
            
            return comparisonResult != ComparisonResult.NotEqual;
        }
    }
}