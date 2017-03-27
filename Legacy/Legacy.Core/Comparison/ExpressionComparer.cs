using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Legacy.Core.Comparison
{
    public class ExpressionComparer
    {
        private IList<INodeComparer> preTypeInterpreter;
        private Dictionary<ExpressionType, List<INodeComparer>> interpreterPerType;

        public ExpressionComparer(IEnumerable<INodeComparer> comparisonSemantics)
        {
            preTypeInterpreter = new List<INodeComparer>();
            interpreterPerType = new Dictionary<ExpressionType, List<INodeComparer>>();
            foreach (var expressionType in Enum.GetValues(typeof(ExpressionType)))
                interpreterPerType.Add((ExpressionType)expressionType, new List<INodeComparer>());

            foreach (var comparer in comparisonSemantics)
            {
                var typeComparer = comparer as INodeComparerForType;
                if (typeComparer != null)
                    interpreterPerType[typeComparer.NodeType].Add(comparer);
                else
                    preTypeInterpreter.Add(comparer);
            }

        }

        public ExpressionComparer(params INodeComparer[] comparisonSemantics) : this(comparisonSemantics as IEnumerable<INodeComparer>) { }

        public bool AreEqual(LambdaExpression left, LambdaExpression right)
        {
            return new ComparisonEffector(this).Compare(left, right) != ComparisonResult.NotEqual;
        }

        public IComparisonEffector GetSubtreeComparer()
        {
            return new ComparisonEffector(this);
        }

        private class ComparisonEffector : IComparisonEffector
        {
            private readonly ExpressionComparer parentUnit;

            public IList<ParameterExpression> LeftParameters { get; }

            public IList<ParameterExpression> RightParameters { get; }

            private List<LabelTarget> LeftTargets { get; }

            private List<LabelTarget> RightTargets { get; }

            public ComparisonEffector(ExpressionComparer parentUnit)
            {
                this.parentUnit = parentUnit;
                LeftTargets = new List<LabelTarget>();
                RightTargets = new List<LabelTarget>();
                LeftParameters = new List<ParameterExpression>();
                RightParameters = new List<ParameterExpression>();
            }

            private ComparisonEffector(ComparisonEffector source, ParameterExpression left, ParameterExpression right)
            {
                parentUnit = source.parentUnit;
                LeftTargets = source.LeftTargets;
                RightTargets = source.RightTargets;
                LeftParameters = new List<ParameterExpression>(source.LeftParameters);
                RightParameters = new List<ParameterExpression>(source.RightParameters);

                LeftParameters.Add(left);
                RightParameters.Add(right);
            }

            private ComparisonEffector(ComparisonEffector source, IEnumerable<ParameterExpression> left, IEnumerable<ParameterExpression> right)
            {
                parentUnit = source.parentUnit;
                LeftTargets = source.LeftTargets;
                RightTargets = source.RightTargets;

                LeftParameters = new List<ParameterExpression>(
                    source.LeftParameters.Count == 0 ?
                    left :
                    System.Linq.Enumerable.Concat(source.LeftParameters, left));
                RightParameters = new List<ParameterExpression>(
                    source.RightParameters.Count == 0 ?
                    right :
                    System.Linq.Enumerable.Concat(source.RightParameters, right));
            }

            public IComparisonEffector WithPairedParameters(ParameterExpression left, ParameterExpression right) => new ComparisonEffector(this, left, right);

            public IComparisonEffector WithPairedParameters(IEnumerable<ParameterExpression> left, IEnumerable<ParameterExpression> right) => new ComparisonEffector(this, left, right);

            public bool AreLabelTargetsPaired(LabelTarget left, LabelTarget right)
            {
                for (int i = 0; i < LeftTargets.Count; i++)
                    if (LeftTargets[i] == left)
                        return RightTargets[i] == right;
                    else if (RightTargets[i] == right)
                        return false;
                
                LeftTargets.Add(left);
                RightTargets.Add(right);
                return true;
            }

            public ComparisonResult Compare(Expression left, Expression right)
            {
                var areEqual = ComparisonResult.PartiallyEqual;
                var genericComparers = parentUnit.preTypeInterpreter;
                for (int i = 0; i < genericComparers.Count && areEqual == ComparisonResult.PartiallyEqual; i++)
                    areEqual = genericComparers[i].AreEqual(this, left, right);

                var currentComparers = parentUnit.interpreterPerType[left.NodeType];
                for (int i = 0; i < currentComparers.Count && areEqual == ComparisonResult.PartiallyEqual; i++)
                    areEqual =  currentComparers[i].AreEqual(this, left, right);

                return areEqual;
            }
        }
    }
}
