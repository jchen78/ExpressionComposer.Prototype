using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class MemberInitNodeComparer : INodeComparerForType
    {
        private IMemberBindingComparer memberBindingComparer;

        public MemberInitNodeComparer(IMemberBindingComparer memberBindingComparer)
        {
            this.memberBindingComparer = memberBindingComparer;
        }

        public ExpressionType NodeType => ExpressionType.MemberInit;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            MemberInitExpression
                left = (MemberInitExpression)leftExpression,
                right = (MemberInitExpression)rightExpression;

            if (left.Bindings.Count != right.Bindings.Count)
                return ComparisonResult.NotEqual;

            for (int i = 0; i < left.Bindings.Count; i++)
            {
                MemberBinding
                    leftBinding = left.Bindings[i],
                    rightBinding = right.Bindings[i];

                if (leftBinding.BindingType != rightBinding.BindingType)
                    return ComparisonResult.NotEqual;

                switch (leftBinding.BindingType)
                {
                    case MemberBindingType.Assignment:
                        if (memberBindingComparer.AreEqual(childrenComparer, (MemberAssignment)leftBinding, (MemberAssignment)rightBinding) == ComparisonResult.NotEqual)
                            return ComparisonResult.NotEqual;
                        break;
                    case MemberBindingType.ListBinding:
                        if (memberBindingComparer.AreEqual(childrenComparer, (MemberListBinding)leftBinding, (MemberListBinding)rightBinding) == ComparisonResult.NotEqual)
                            return ComparisonResult.NotEqual;
                        break;
                    case MemberBindingType.MemberBinding:
                        if (memberBindingComparer.AreEqual(childrenComparer, (MemberMemberBinding)leftBinding, (MemberMemberBinding)rightBinding) == ComparisonResult.NotEqual)
                            return ComparisonResult.NotEqual;
                        break;
                }
            }

            return ComparisonResult.PartiallyEqual;
        }
    }
}