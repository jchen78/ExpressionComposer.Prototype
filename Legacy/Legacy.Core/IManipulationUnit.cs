using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Legacy.Core
{
    public interface IManipulationUnit
    {
        LambdaExpression ExtractToLambda();

        Expression Extract(ReadOnlyCollection<ParameterExpression> uniformParameters);

        ReadOnlyCollection<ParameterExpression> Parameters { get; }

        ManipulationType UnitType { get; }
    }

    public interface IUnitHolder : IManipulationUnit { IManipulationUnit InnerUnit { get; } }
}
