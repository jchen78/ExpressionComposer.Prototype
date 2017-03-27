using System;
using System.Linq.Expressions;
using static System.Linq.Expressions.ExpressionType;

namespace Legacy.Core.Comparison.Commutative
{
    public class BinaryNodeCommutativeOperationComparer : INodeComparerForType
    {
        public BinaryNodeCommutativeOperationComparer(ExpressionType nodeType)
        {
            switch (nodeType) {
                case Add:
                case AddChecked:
                case And:
                case AndAlso:
                case Equal:
                case ExclusiveOr:
                case Multiply:
                case MultiplyChecked:
                case Or:
                case OrElse:
                    NodeType = nodeType;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public ExpressionType NodeType { get; }

        public virtual ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            var left = (BinaryExpression)leftExpression;
            var right = (BinaryExpression)rightExpression;

            if (childrenComparer.Compare(left.Left, right.Left) == ComparisonResult.NotEqual) {
                if (childrenComparer.Compare(left.Left, right.Right) == ComparisonResult.NotEqual)
                    return ComparisonResult.NotEqual;

                return childrenComparer.Compare(left.Right, right.Left);
            }

            return childrenComparer.Compare(left.Right, right.Right);
        }
    }
}
