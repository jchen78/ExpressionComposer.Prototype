using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Legacy.Core
{
    public class TrivialUnit : IManipulationUnit
    {
        private readonly LambdaExpression lambda;

        public TrivialUnit(LambdaExpression startingPoint)
        {
            lambda = startingPoint;
            Parameters = lambda.Parameters;
        }

        public ManipulationType UnitType => ManipulationType.LambdaHolder;

        public ReadOnlyCollection<ParameterExpression> Parameters { get; }

        public Expression Extract(ReadOnlyCollection<ParameterExpression> uniformParameters)
        {
            var replacements = new Dictionary<ParameterExpression, Expression>();
            for (int i = 0; i < uniformParameters.Count; i++)
                replacements.Add(lambda.Parameters[i], uniformParameters[i]);

            return new ParameterExchanger(replacements).Visit(lambda.Body);
        }

        public LambdaExpression ExtractToLambda() => lambda;
    }
}
