using System.Linq.Expressions;

namespace Legacy.Core.Comparison.Strict
{
    public class DebugInfoNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.DebugInfo;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            DebugInfoExpression
                left = (DebugInfoExpression)leftExpression,
                right = (DebugInfoExpression)rightExpression;

            if (left.StartLine != right.StartLine
                || left.StartColumn != right.StartColumn
                || left.EndLine != right.EndLine
                || left.EndColumn != right.EndColumn
                || left.Document.FileName != right.Document.FileName
                || left.Document.Language != right.Document.Language
                || left.Document.LanguageVendor != right.Document.LanguageVendor
                || left.Document.DocumentType != right.Document.DocumentType)
                return ComparisonResult.NotEqual;

            return ComparisonResult.PartiallyEqual;
        }
    }
}