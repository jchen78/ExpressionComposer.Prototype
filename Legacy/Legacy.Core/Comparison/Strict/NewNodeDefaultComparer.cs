using System.Collections.Generic;
using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class NewNodeDefaultComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.New;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            NewExpression
                left = (NewExpression)leftExpression,
                right = (NewExpression)rightExpression;

            if (!IsSameConstructor(left, right)
                || !AreParametersEqual(childrenComparer, left.Arguments, right.Arguments))
                return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }

        private bool IsSameConstructor(NewExpression left, NewExpression right)
        {
            return left.Constructor == right.Constructor;
        }
 
        private bool AreParametersEqual(IComparisonEffector childrenComparer, IList<Expression> left, IList<Expression> right)
        {
            for (int i = 0; i < left.Count; i++)
                if (childrenComparer.Compare(left[i], right[i]) == ComparisonResult.NotEqual)
                    return false;

            return true;
        }
   }
}