using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Legacy.Core.Composition
{
    public class UnaryComposer : IManipulationUnit
    {
        private readonly IManipulationUnit originalExpression;
        private readonly ParameterExpression placeholder;
        private readonly LambdaExpression newExpression;

        public UnaryComposer(IManipulationUnit originalExpression, LambdaExpression compositionSemantics)
        {
            this.originalExpression = originalExpression.UnitType == ManipulationType.UnitHolder ? ((IUnitHolder)originalExpression).InnerUnit : originalExpression;
            placeholder = compositionSemantics.Parameters[0];

            var compositionBody = compositionSemantics.Body;
            newExpression =
                compositionBody.NodeType == ExpressionType.Quote ?
                (LambdaExpression)((UnaryExpression)compositionSemantics.Body).Operand :
                (LambdaExpression)compositionSemantics.Body;

            Parameters = newExpression.Parameters;
        }

        public ReadOnlyCollection<ParameterExpression> Parameters { get; }

        public ManipulationType UnitType => ManipulationType.UnaryComposition;

        public Expression Extract(ReadOnlyCollection<ParameterExpression> uniformParameters)
        {
            var normalizedOriginal = originalExpression.Extract(uniformParameters);
            var replacements = new Dictionary<ParameterExpression, Expression> { { placeholder, normalizedOriginal } };
            for (int i = 0; i < uniformParameters.Count; i++)
                replacements.Add(newExpression.Parameters[i], uniformParameters[i]);

            return new ParameterExchanger(replacements).Visit(newExpression.Body);
        }

        public LambdaExpression ExtractToLambda()
        {
            var normalizedOriginal = originalExpression.Extract(Parameters);
            var replacements = new Dictionary<ParameterExpression, Expression> { { placeholder, normalizedOriginal } };
            return (LambdaExpression)(new ParameterExchanger(replacements).Visit(newExpression));
        }
    }
}
