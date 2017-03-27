using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class ListInitNodeSequentialComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.ListInit;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            ListInitExpression
                left = (ListInitExpression)leftExpression,
                right = (ListInitExpression)rightExpression;

            if (left.Initializers.Count != right.Initializers.Count)
                return ComparisonResult.NotEqual;

            for (int i = 0; i < left.Initializers.Count; i++)
                if (!AreInitializersEqual(childrenComparer, left.Initializers[i], right.Initializers[i]))
                    return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }

        private bool AreInitializersEqual(IComparisonEffector subtreeComparer, ElementInit left, ElementInit right)
        {
            if (left.AddMethod != right.AddMethod)
                return false;

            for (int i = 0; i < left.Arguments.Count; i++)
                if (subtreeComparer.Compare(left.Arguments[i], right.Arguments[i]) == ComparisonResult.NotEqual)
                    return false;

            return true;
        }
    }
}