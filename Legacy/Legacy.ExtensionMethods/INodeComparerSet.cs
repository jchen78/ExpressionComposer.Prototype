using System.Collections.Generic;
using Legacy.Core.Comparison;

namespace Legacy.ExtensionMethods
{
    public interface INodeComparerSet
    {
        IEnumerable<INodeComparer> UniversalComparers { get; }

        #region Comparers for specific ExpressionType values

        IEnumerable<INodeComparerForType> AddComparers { get; }
        IEnumerable<INodeComparerForType> AddAssignComparers { get; }
        IEnumerable<INodeComparerForType> AddAssignCheckedComparers { get; }
        IEnumerable<INodeComparerForType> AddCheckedComparers { get; }
        IEnumerable<INodeComparerForType> AndComparers { get; }
        IEnumerable<INodeComparerForType> AndAlsoComparers { get; }
        IEnumerable<INodeComparerForType> AndAssignComparers { get; }
        IEnumerable<INodeComparerForType> ArrayIndexComparers { get; }
        IEnumerable<INodeComparerForType> ArrayLengthComparers { get; }
        IEnumerable<INodeComparerForType> AssignComparers { get; }
        IEnumerable<INodeComparerForType> BlockComparers { get; }
        IEnumerable<INodeComparerForType> CallComparers { get; }
        IEnumerable<INodeComparerForType> CoalesceComparers { get; }
        IEnumerable<INodeComparerForType> ConditionalComparers { get; }
        IEnumerable<INodeComparerForType> ConstantComparers { get; }
        IEnumerable<INodeComparerForType> ConvertComparers { get; }
        IEnumerable<INodeComparerForType> ConvertCheckedComparers { get; }
        IEnumerable<INodeComparerForType> DebugInfoComparers { get; }
        IEnumerable<INodeComparerForType> DecrementComparers { get; }
        IEnumerable<INodeComparerForType> DivideComparers { get; }
        IEnumerable<INodeComparerForType> DivideAssignComparers { get; }
        IEnumerable<INodeComparerForType> DynamicComparers { get; }
        IEnumerable<INodeComparerForType> EqualComparers { get; }
        IEnumerable<INodeComparerForType> ExclusiveOrComparers { get; }
        IEnumerable<INodeComparerForType> ExclusiveOrAssignComparers { get; }
        IEnumerable<INodeComparerForType> ExtensionComparers { get; }
        IEnumerable<INodeComparerForType> GotoComparers { get; }
        IEnumerable<INodeComparerForType> GreaterThanComparers { get; }
        IEnumerable<INodeComparerForType> GreaterThanOrEqualComparers { get; }
        IEnumerable<INodeComparerForType> IncrementComparers { get; }
        IEnumerable<INodeComparerForType> IndexComparers { get; }
        IEnumerable<INodeComparerForType> InvokeComparers { get; }
        IEnumerable<INodeComparerForType> IsFalseComparers { get; }
        IEnumerable<INodeComparerForType> IsTrueComparers { get; }
        IEnumerable<INodeComparerForType> LabelComparers { get; }
        IEnumerable<INodeComparerForType> LambdaComparers { get; }
        IEnumerable<INodeComparerForType> LeftShiftComparers { get; }
        IEnumerable<INodeComparerForType> LeftShiftAssignComparers { get; }
        IEnumerable<INodeComparerForType> LessThanComparers { get; }
        IEnumerable<INodeComparerForType> LessThanLessThanOrEqualComparers { get; }
        IEnumerable<INodeComparerForType> ListInitComparers { get; }
        IEnumerable<INodeComparerForType> LoopComparers { get; }
        IEnumerable<INodeComparerForType> MemberAccessComparers { get; }
        IEnumerable<INodeComparerForType> MemberInitComparers { get; }
        IEnumerable<INodeComparerForType> ModuloComparers { get; }
        IEnumerable<INodeComparerForType> ModuloAssignComparers { get; }
        IEnumerable<INodeComparerForType> MultiplyComparers { get; }
        IEnumerable<INodeComparerForType> MultiplyAssignComparers { get; }
        IEnumerable<INodeComparerForType> MultiplyAssignCheckedComparers { get; }
        IEnumerable<INodeComparerForType> MultiplyCheckedComparers { get; }
        IEnumerable<INodeComparerForType> NegateComparers { get; }
        IEnumerable<INodeComparerForType> NegateCheckedComparers { get; }
        IEnumerable<INodeComparerForType> NewComparers { get; }
        IEnumerable<INodeComparerForType> NewArrayBoundsComparers { get; }
        IEnumerable<INodeComparerForType> NewArrayInitComparers { get; }
        IEnumerable<INodeComparerForType> NotComparers { get; }
        IEnumerable<INodeComparerForType> NotEqualComparers { get; }
        IEnumerable<INodeComparerForType> OnesComplementComparers { get; }
        IEnumerable<INodeComparerForType> OrComparers { get; }
        IEnumerable<INodeComparerForType> OrAssignComparers { get; }
        IEnumerable<INodeComparerForType> OrElseComparers { get; }
        IEnumerable<INodeComparerForType> ParameterComparers { get; }
        IEnumerable<INodeComparerForType> PostDecrementAssignComparers { get; }
        IEnumerable<INodeComparerForType> PostIncrementAssignComparers { get; }
        IEnumerable<INodeComparerForType> PowerComparers { get; }
        IEnumerable<INodeComparerForType> PowerAssignComparers { get; }
        IEnumerable<INodeComparerForType> PreDecrementAssignComparers { get; }
        IEnumerable<INodeComparerForType> PreIncrementAssignComparers { get; }
        IEnumerable<INodeComparerForType> QuoteComparers { get; }
        IEnumerable<INodeComparerForType> RightShiftComparers { get; }
        IEnumerable<INodeComparerForType> RightShiftAssignComparers { get; }
        IEnumerable<INodeComparerForType> RuntimeVariablesComparers { get; }
        IEnumerable<INodeComparerForType> SubtractComparers { get; }
        IEnumerable<INodeComparerForType> SubtractAssignComparers { get; }
        IEnumerable<INodeComparerForType> SubtractAssignCheckedComparers { get; }
        IEnumerable<INodeComparerForType> SubtractCheckedComparers { get; }
        IEnumerable<INodeComparerForType> SwitchComparers { get; }
        IEnumerable<INodeComparerForType> ThrowComparers { get; }
        IEnumerable<INodeComparerForType> TryComparers { get; }
        IEnumerable<INodeComparerForType> TypeAsComparers { get; }
        IEnumerable<INodeComparerForType> TypeEqualComparers { get; }
        IEnumerable<INodeComparerForType> TypeIsComparers { get; }
        IEnumerable<INodeComparerForType> UnaryPlusComparers { get; }
        IEnumerable<INodeComparerForType> UnboxComparers { get; }
        IEnumerable<INodeComparer> ComparisonSemantics { get; }

        #endregion Comparers for specific ExpressionType values

        #region Comparers for related non-expression types

        IMemberBindingComparer MemberBindingComparer { get; }
        ISwitchCaseComparer SwitchCaseComparer { get; }

        #endregion Comparers for related non-expression types
    }
}
