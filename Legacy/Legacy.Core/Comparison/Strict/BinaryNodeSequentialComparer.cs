using System;
using System.Linq.Expressions;

using static System.Linq.Expressions.ExpressionType;

namespace Legacy.Core.Comparison.Strict
{
    public class BinaryNodeSequentialComparer : INodeComparerForType
    {
        public BinaryNodeSequentialComparer(ExpressionType nodeType)
        {
            switch (nodeType) {
                case Add:
                case AddAssign:
                case AddAssignChecked:
                case AddChecked:
                case And:
                case AndAlso:
                case AndAssign:
                case Or:
                case OrAssign:
                case OrElse:
                case ArrayIndex:
                case Assign:
                case Coalesce:
                case Divide:
                case DivideAssign:
                case Modulo:
                case ModuloAssign:
                case Multiply:
                case MultiplyAssign:
                case MultiplyAssignChecked:
                case MultiplyChecked:
                case Equal:
                case NotEqual:
                case ExclusiveOr:
                case ExclusiveOrAssign:
                case GreaterThan:
                case GreaterThanOrEqual:
                case LeftShift:
                case LeftShiftAssign:
                case LessThan:
                case LessThanOrEqual:
                case Power:
                case PowerAssign:
                case RightShift:
                case RightShiftAssign:
                case Subtract:
                case SubtractAssign:
                case SubtractAssignChecked:
                case SubtractChecked:
                    NodeType = nodeType;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public ExpressionType NodeType { get; }

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            var left = (BinaryExpression)leftExpression;
            var right = (BinaryExpression)rightExpression;

            if (childrenComparer.Compare(left.Left, right.Left) == ComparisonResult.NotEqual ||
                childrenComparer.Compare(left.Right, right.Right) == ComparisonResult.NotEqual)
                return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }
    }
}