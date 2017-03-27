using System.Collections.Generic;
using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class ParameterNodeOrdinalComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Parameter;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            var leftIndex = IndexOf(leftExpression, childrenComparer.LeftParameters);
            if (leftIndex == -1)
                return ComparisonResult.NotEqual;

            var rightIndex = IndexOf(rightExpression, childrenComparer.RightParameters);
            if (rightIndex == -1)
                return ComparisonResult.NotEqual;

            return leftIndex == rightIndex ? ComparisonResult.Equal : ComparisonResult.NotEqual;
        }

        private int IndexOf(Expression target, IList<ParameterExpression> collection)
        {
            for (int i = 0; i < collection.Count; i++)
                if (collection[i] == target)
                    return i;
            return -1;
        }
    }
}