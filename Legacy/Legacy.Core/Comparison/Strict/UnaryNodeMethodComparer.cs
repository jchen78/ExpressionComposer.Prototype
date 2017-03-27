using System;
using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class UnaryNodeMethodComparer : INodeComparerForType
    {
        public UnaryNodeMethodComparer(ExpressionType expressionType)
        {
            switch (expressionType) {
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
            return
                ((UnaryExpression)leftExpression).Method == ((UnaryExpression)rightExpression).Method ?
                ComparisonResult.PartiallyEqual :
                ComparisonResult.NotEqual;
        }
    }
}