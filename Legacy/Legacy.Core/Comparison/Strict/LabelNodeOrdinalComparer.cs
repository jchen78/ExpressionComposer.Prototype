using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class LabelNodeOrdinalComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Label;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            LabelExpression
                left = (LabelExpression)leftExpression,
                right = (LabelExpression)rightExpression;

            if (!childrenComparer.AreLabelTargetsPaired(left.Target, right.Target))
                return ComparisonResult.NotEqual;

            if (!AreDefaultValuesEqual(childrenComparer, left.DefaultValue, right.DefaultValue))
                return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }

        private bool AreDefaultValuesEqual(IComparisonEffector childrenComparer, Expression left, Expression right)
        {
            if (left == null)
                return right == null;

            if (right == null)
                return false;

            return childrenComparer.Compare(left, right) != ComparisonResult.NotEqual;
        }
    }
}