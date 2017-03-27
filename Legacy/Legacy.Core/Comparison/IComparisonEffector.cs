using Legacy.Core.Comparison;
using System.Collections.Generic;
using System.Linq.Expressions;

public interface IComparisonEffector
{
    IComparisonEffector WithPairedParameters(ParameterExpression left, ParameterExpression right);
    IComparisonEffector WithPairedParameters(IEnumerable<ParameterExpression> left, IEnumerable<ParameterExpression> right);
    bool AreLabelTargetsPaired(LabelTarget left, LabelTarget right);
    ComparisonResult Compare(Expression left, Expression right);
    IList<ParameterExpression> LeftParameters { get; }
    IList<ParameterExpression> RightParameters { get; }
}
