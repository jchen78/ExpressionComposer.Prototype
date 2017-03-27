using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class LambdaNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Lambda;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            var leftLambda = (LambdaExpression)leftExpression;
            var rightLambda = (LambdaExpression)rightExpression;

            if (leftLambda.Parameters.Count != rightLambda.Parameters.Count)
                return ComparisonResult.NotEqual;

            for (int i = 0; i < leftLambda.Parameters.Count; i++)
                if (leftLambda.Parameters[i].Type != rightLambda.Parameters[i].Type)
                    return ComparisonResult.NotEqual;

            return childrenComparer.WithPairedParameters(leftLambda.Parameters, rightLambda.Parameters).Compare(((LambdaExpression)leftExpression).Body, ((LambdaExpression)rightExpression).Body);
        }
    }
}