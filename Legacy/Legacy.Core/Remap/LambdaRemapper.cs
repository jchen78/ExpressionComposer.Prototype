using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Legacy.Core.Remap
{
    public class LambdaRemapper : IManipulationUnit
    {
        private IManipulationUnit originalExpression;
        private ParameterExpression lambdaPlaceholder;
        private LambdaExpression newExpression;

        public LambdaRemapper(IManipulationUnit originalExpression, LambdaExpression remappedExpression, ParameterExpression lambdaPlaceholder)
        {
            // TODO: "Quote" original expression to know which parameters belong to the inner lambda
            this.originalExpression = originalExpression;
            this.lambdaPlaceholder = lambdaPlaceholder;
            newExpression = remappedExpression;
            Parameters = remappedExpression.Parameters;
        }

        public ReadOnlyCollection<ParameterExpression> Parameters { get; }

        public ManipulationType UnitType => ManipulationType.LambdaRemap;

        public Expression Extract(ReadOnlyCollection<ParameterExpression> uniformParameters)
        {
            var uniformOriginalExpression = GetUniformInnerLambda(uniformParameters);
            Dictionary<ParameterExpression, Expression> replacements = new Dictionary<ParameterExpression, Expression>() { { lambdaPlaceholder, uniformOriginalExpression } };
            for (int j = 0; j < newExpression.Parameters.Count; j++)
                replacements.Add(newExpression.Parameters[j], uniformParameters[j]);

            return new ParameterExchanger(replacements).Visit(newExpression.Body);
        }

        public LambdaExpression ExtractToLambda()
        {
            return (LambdaExpression)(new ParameterExchanger(new Dictionary<ParameterExpression, Expression> { { lambdaPlaceholder, GetUniformInnerLambda(Parameters) } }).Visit(newExpression));
        }

        private LambdaExpression GetUniformInnerLambda(ReadOnlyCollection<ParameterExpression> uniformOuterParameters)
        {
            var uniformInnerParameters = new ParameterExpression[originalExpression.Parameters.Count];
            var fixedInnerParameters = new ParameterExpression[uniformInnerParameters.Length - uniformOuterParameters.Count];
            int i = 0;
            for (; i < uniformOuterParameters.Count; i++)
                uniformInnerParameters[i] = uniformOuterParameters[i];
            for (int j = 0; i < uniformInnerParameters.Length; i++, j++)
                fixedInnerParameters[j] = uniformInnerParameters[i] = originalExpression.Parameters[i];
            var uniformOriginalExpression = Expression.Lambda(originalExpression.Extract(new ReadOnlyCollection<ParameterExpression>(uniformInnerParameters)), fixedInnerParameters);

            return uniformOriginalExpression;
        }
    }
}
