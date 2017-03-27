using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Legacy.Core.Remap
{
    public class ParameterRemapper : IManipulationUnit
    {
        private readonly IManipulationUnit originalExpression;
        private readonly Dictionary<ParameterExpression, IManipulationUnit> replacements;

        public ParameterRemapper(IManipulationUnit originalExpression, Dictionary<ParameterExpression, IManipulationUnit> replacements)
        {
            this.originalExpression = originalExpression.UnitType == ManipulationType.UnitHolder ? ((IUnitHolder)originalExpression).InnerUnit : originalExpression;
            this.replacements = replacements;
            Parameters = getReplacedParameters(originalExpression.Parameters, replacements);
        }

        private ReadOnlyCollection<ParameterExpression> getReplacedParameters(ReadOnlyCollection<ParameterExpression> originalExpression, Dictionary<ParameterExpression, IManipulationUnit> replacements)
        {
            var parameters = new List<ParameterExpression>(originalExpression.Count);
            IManipulationUnit replacement = null;
            for (int i = 0; i < originalExpression.Count; i++) {
                if (!replacements.TryGetValue(originalExpression[i], out replacement))
                    parameters.Add(originalExpression[i]);
                else
                    parameters.AddRange(replacement.Parameters);
            }

            return new ReadOnlyCollection<ParameterExpression>(parameters);
        }

        public ReadOnlyCollection<ParameterExpression> Parameters { get; }

        public ManipulationType UnitType => ManipulationType.ParameterRemap;

        public Expression Extract(ReadOnlyCollection<ParameterExpression> uniformParameters)
        {
            var parameterReplacements = new Dictionary<ParameterExpression, Expression>();
            for (int i = 0; i < uniformParameters.Count; i++)
                parameterReplacements.Add(Parameters[i], uniformParameters[i]);

            var uniformReplacements = new Dictionary<ParameterExpression, Expression>();
            foreach (var replacement in replacements)
                uniformReplacements.Add(replacement.Key, replacement.Value.Extract(uniformParameters));

            return new ParameterExchanger(uniformReplacements).Visit(originalExpression.Extract(originalExpression.Parameters));
        }

        public LambdaExpression ExtractToLambda()
        {
            var extractedReplacements = new Dictionary<ParameterExpression, Expression>();
            foreach (var replacement in replacements)
                extractedReplacements.Add(replacement.Key, replacement.Value.ExtractToLambda().Body);

            return Expression.Lambda(new ParameterExchanger(extractedReplacements).Visit(originalExpression.Extract(originalExpression.Parameters)), Parameters);
        }

        private class ParameterRetriever : ExpressionVisitor
        {
            private ParameterExpression parameter;
            
            protected override Expression VisitParameter(ParameterExpression node)
            {
                parameter = node;
                return base.VisitParameter(node);
            }

            public ParameterExpression GetParameter(Expression targetExpression)
            {
                parameter = null;
                Visit(targetExpression);
                return parameter;
            }
        }
    }
}
