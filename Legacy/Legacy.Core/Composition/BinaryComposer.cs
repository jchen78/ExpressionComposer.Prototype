using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Legacy.Core.Composition
{
    public class BinaryComposer : IManipulationUnit
    {
        private readonly IManipulationUnit left;
        private readonly IManipulationUnit right;
        private readonly ParameterExpression leftPlaceholder;
        private readonly ParameterExpression rightPlaceholder;
        private readonly LambdaExpression compositionDefinition;

        public BinaryComposer(IManipulationUnit left, IManipulationUnit right, LambdaExpression compositionFunction)
        {
            this.left = left.UnitType == ManipulationType.UnitHolder ? ((IUnitHolder)left).InnerUnit : left;
            this.right = right.UnitType == ManipulationType.UnitHolder ? ((IUnitHolder)right).InnerUnit : right;
            leftPlaceholder = compositionFunction.Parameters[0];
            rightPlaceholder = compositionFunction.Parameters[1];

            var compositionBody = compositionFunction.Body;
            compositionDefinition =
                compositionBody.NodeType == ExpressionType.Quote ?
                (LambdaExpression)((UnaryExpression)compositionFunction.Body).Operand :
                (LambdaExpression)compositionBody;
            Parameters = compositionDefinition.Parameters;
        }

        public ReadOnlyCollection<ParameterExpression> Parameters { get; }

        public ManipulationType UnitType => ManipulationType.BinaryComposition;

        public Expression Extract(ReadOnlyCollection<ParameterExpression> uniformParameters)
        {
            var replacements = new Dictionary<ParameterExpression, Expression> {
                { leftPlaceholder, left.Extract(uniformParameters) },
                { rightPlaceholder, right.Extract(uniformParameters) }
            };

            for (int i = 0; i < Parameters.Count; i++)
                replacements.Add(Parameters[i], uniformParameters[i]);

            return new ParameterExchanger(replacements).Visit(compositionDefinition.Body);
        }

        public LambdaExpression ExtractToLambda()
        {
            var replacements = new Dictionary<ParameterExpression, Expression> {
                { leftPlaceholder, left.Extract(Parameters) },
                { rightPlaceholder, right.Extract(Parameters) }
            };

            return (LambdaExpression)(new ParameterExchanger(replacements).Visit(compositionDefinition));
        }
    }
}
