using System;
using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class UnaryNodeOperandComparer : INodeComparerForType
    {
        public UnaryNodeOperandComparer(ExpressionType expressionType)
        {
            switch (expressionType)
            {
                case ExpressionType.ArrayLength:
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                case ExpressionType.Decrement:
                case ExpressionType.Increment:
                case ExpressionType.IsFalse:
                case ExpressionType.IsTrue:
                case ExpressionType.Negate:
                case ExpressionType.NegateChecked:
                case ExpressionType.Not:
                case ExpressionType.OnesComplement:
                case ExpressionType.PostDecrementAssign:
                case ExpressionType.PostIncrementAssign:
                case ExpressionType.PreDecrementAssign:
                case ExpressionType.PreIncrementAssign:
                case ExpressionType.Quote:
                case ExpressionType.Throw:
                case ExpressionType.TypeAs:
                case ExpressionType.UnaryPlus:
                case ExpressionType.Unbox:
                    NodeType = expressionType;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public ExpressionType NodeType { get; }

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            return childrenComparer.Compare(((UnaryExpression)leftExpression).Operand, ((UnaryExpression)rightExpression).Operand);
        }
    }
}