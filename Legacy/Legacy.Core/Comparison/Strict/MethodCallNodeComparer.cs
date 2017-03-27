using System.Collections.Generic;
using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class MethodCallNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Call;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            MethodCallExpression
                left = (MethodCallExpression)leftExpression,
                right = (MethodCallExpression)rightExpression;

            if (left.Method != right.Method
                || !AreArgumentsEqual(childrenComparer, left.Arguments, right.Arguments)
                || !AreObjectsEqual(childrenComparer, left.Object, right.Object))
                return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }

        private bool AreArgumentsEqual(IComparisonEffector childrenComparer, IList<Expression> left, IList<Expression> right)
        {
            for (int i = 0; i < left.Count; i++)
                if (childrenComparer.Compare(left[i], right[i]) == ComparisonResult.NotEqual)
                    return false;

            return true;
        }

        private bool AreObjectsEqual(IComparisonEffector childrenComparer, Expression left, Expression right)
        {
            if (left == null)
                return right == null;

            return childrenComparer.Compare(left, right) != ComparisonResult.NotEqual;
        }
    }
}