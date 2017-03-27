using System.Linq.Expressions;

namespace Legacy.Core.Comparison
{
    public interface INodeComparer
    {
        ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression);
    }

    public interface INodeComparerForType : INodeComparer
    {
        ExpressionType NodeType { get; }
    }

    public enum ComparisonResult
    {
        Equal,
        NotEqual,
        PartiallyEqual
    }
}
