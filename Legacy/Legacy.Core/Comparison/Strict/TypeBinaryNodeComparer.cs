using System;
using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class TypeBinaryNodeComparer : INodeComparerForType
    {
        public TypeBinaryNodeComparer(ExpressionType nodeType)
        {
            switch (nodeType)
            {
                case ExpressionType.TypeEqual:
                case ExpressionType.TypeIs:
                    NodeType = nodeType;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public ExpressionType NodeType { get; }

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            TypeBinaryExpression
                left = (TypeBinaryExpression)leftExpression,
                right = (TypeBinaryExpression)rightExpression;

            if (left.TypeOperand != right.TypeOperand)
                return ComparisonResult.NotEqual;

            return childrenComparer.Compare(left.Expression, right.Expression);
        }
    }
}