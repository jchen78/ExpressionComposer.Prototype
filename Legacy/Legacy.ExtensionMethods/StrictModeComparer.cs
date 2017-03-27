using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Legacy.Core.Comparison;
using Legacy.Core.Comparison.Strict;

namespace Legacy.ExtensionMethods
{
    public static class StrictModeComparer
    {
        private static Lazy<INodeComparerSet> comparerSet = new Lazy<INodeComparerSet>(() => new ComparerSetImplementation());

        public static INodeComparerSet StrictModeComparerSet => comparerSet.Value;

        private static Func<ExpressionComparer> getDefaultComparer = () => new ExpressionComparer(comparerSet.Value.ComparisonSemantics);
        public static void SetExpressionComparer(Func<ExpressionComparer> comparerCreator) => getDefaultComparer = comparerCreator;

        public static IComparisonEffector GetSubtreeComparer() => getDefaultComparer().GetSubtreeComparer();

        public static bool AreEqual(LambdaExpression left, LambdaExpression right) => getDefaultComparer().AreEqual(left, right);

        private class ComparerSetImplementation : INodeComparerSet
        {
            #region Lazy initializers

            private static Lazy<INodeComparer>
                nodeExpressionType = new Lazy<INodeComparer>(() => new NodeExpressionTypeComparer()),
                nodeClrType = new Lazy<INodeComparer>(() => new NodeClrTypeComparer());

            private static Lazy<INodeComparerForType>
                addComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.Add)),
                addAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.AddAssign)),
                addAssignCheckedComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.AddAssign)),
                addCheckedComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.AddAssign)),
                andComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.And)),
                andAlsoComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.AndAlso)),
                andAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.AndAssign)),
                arrayIndexComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.ArrayIndex)),
                arrayLengthComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.ArrayLength)),
                assignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.Assign)),
                blockComparer = new Lazy<INodeComparerForType>(() => new BlockNodeComparer()),
                callComparer = new Lazy<INodeComparerForType>(() => new MethodCallNodeComparer()),
                coalesceComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.Coalesce)),
                conditionalComparer = new Lazy<INodeComparerForType>(() => new ConditionalNodeComparer()),
                constantComparer = new Lazy<INodeComparerForType>(() => new ConstantNodeDefaultEqualityComparer()),
                convertMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.Convert)),
                convertOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.Convert)),
                convertCheckedMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.ConvertChecked)),
                convertCheckedOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.ConvertChecked)),
                debugInfoComparer = new Lazy<INodeComparerForType>(() => new DebugInfoNodeComparer()),
                decrementMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.Decrement)),
                decrementOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.Decrement)),
                divideComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.Divide)),
                divideAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.DivideAssign)),
                dynamicComparer = new Lazy<INodeComparerForType>(() => new DynamicNodeComparer()),
                equalComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.Equal)),
                exclusiveOrComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.ExclusiveOr)),
                exclusiveOrAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.ExclusiveOrAssign)),
                gotoComparer = new Lazy<INodeComparerForType>(() => new GotoNodeComparer()),
                greaterThanComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.GreaterThan)),
                greaterThanOrEqualComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.GreaterThanOrEqual)),
                incrementMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.Increment)),
                incrementOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.Increment)),
                indexComparer = new Lazy<INodeComparerForType>(() => new IndexNodeComparer()),
                invokeComparer = new Lazy<INodeComparerForType>(() => new InvokeNodeComparer()),
                isFalseMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.IsFalse)),
                isFalseOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.IsFalse)),
                isTrueMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.IsTrue)),
                isTrueOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.IsTrue)),
                labelComparer = new Lazy<INodeComparerForType>(() => new LabelNodeOrdinalComparer()),
                lambdaComparer = new Lazy<INodeComparerForType>(() => new LambdaNodeComparer()),
                leftShiftComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.LeftShift)),
                leftShiftAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.LeftShiftAssign)),
                lessThanComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.LessThan)),
                lessThanOrEqualComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.LessThanOrEqual)),
                listInitComparer = new Lazy<INodeComparerForType>(() => new ListInitNodeSequentialComparer()),
                loopComparer = new Lazy<INodeComparerForType>(() => new LoopNodeComparer()),
                memberAccessComparer = new Lazy<INodeComparerForType>(() => new MemberAccessNodeComparer()),
                memberInitComparer = new Lazy<INodeComparerForType>(() => new MemberInitNodeComparer(new MemberBindingSequentialComparer())),
                moduloComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.Modulo)),
                moduloAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.ModuloAssign)),
                multiplyComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.Multiply)),
                multiplyAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.MultiplyAssign)),
                multiplyAssignCheckedComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.MultiplyAssignChecked)),
                multiplyCheckedComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.MultiplyChecked)),
                negateMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.Negate)),
                negateOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.Negate)),
                negateCheckedMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.NegateChecked)),
                negateCheckedOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.NegateChecked)),
                newComparer = new Lazy<INodeComparerForType>(() => new NewNodeDefaultComparer()),
                newArrayBoundsComparer = new Lazy<INodeComparerForType>(() => new NewArrayBoundsNodeComparer()),
                newArrayInitComparer = new Lazy<INodeComparerForType>(() => new NewArrayInitNodeSequentialComparer()),
                notMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.Not)),
                notOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.Not)),
                notEqualComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.NotEqual)),
                onesComplementMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.OnesComplement)),
                onesComplementOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.OnesComplement)),
                orComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.Or)),
                orAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.OrAssign)),
                orElseComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.OrElse)),
                parameterComparer = new Lazy<INodeComparerForType>(() => new ParameterNodeOrdinalComparer()),
                postDecrementAssignMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.PostDecrementAssign)),
                postDecrementAssignOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.PostDecrementAssign)),
                postIncrementAssignMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.PostIncrementAssign)),
                postIncrementAssignOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.PostIncrementAssign)),
                powerComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.Power)),
                powerAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.PowerAssign)),
                preDecrementAssignMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.PreDecrementAssign)),
                preDecrementAssignOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.PreDecrementAssign)),
                preIncrementAssignMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.PreIncrementAssign)),
                preIncrementAssignOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.PreIncrementAssign)),
                quoteComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.Quote)),
                rightShiftComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.RightShift)),
                rightShiftAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.RightShiftAssign)),
                runtimeVariablesComparer = new Lazy<INodeComparerForType>(() => new RuntimeVariablesNodeSequentialComparer()),
                subtractComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.Subtract)),
                subtractAssignComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.SubtractAssign)),
                subtractAssignCheckedComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.SubtractAssignChecked)),
                subtractCheckedComparer = new Lazy<INodeComparerForType>(() => new BinaryNodeSequentialComparer(ExpressionType.SubtractChecked)),
                switchComparer = new Lazy<INodeComparerForType>(() => new SwitchNodeComparer(new SwitchCaseComparer())),
                throwComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.Throw)),
                tryComparer = new Lazy<INodeComparerForType>(() => new TryNodeSequentialComparer()),
                typeAsComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.TypeAs)),
                typeEqualComparer = new Lazy<INodeComparerForType>(() => new TypeBinaryNodeComparer(ExpressionType.TypeEqual)),
                typeIsComparer = new Lazy<INodeComparerForType>(() => new TypeBinaryNodeComparer(ExpressionType.TypeIs)),
                unaryPlusMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.UnaryPlus)),
                unaryPlusOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.UnaryPlus)),
                unboxMethodComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeMethodComparer(ExpressionType.Unbox)),
                unboxOperandComparer = new Lazy<INodeComparerForType>(() => new UnaryNodeOperandComparer(ExpressionType.Unbox));

            private Lazy<IMemberBindingComparer> memberBindingComparer = new Lazy<IMemberBindingComparer>(() => new MemberBindingSequentialComparer());
            private Lazy<ISwitchCaseComparer> switchCaseComparer = new Lazy<ISwitchCaseComparer>(() => new SwitchCaseComparer());

            private Lazy<ReadOnlyCollection<INodeComparer>> allComparers = new Lazy<ReadOnlyCollection<INodeComparer>>(() => new ReadOnlyCollection<INodeComparer>(new[] {
                nodeExpressionType.Value,
                nodeClrType.Value,
                addComparer.Value,
                addAssignComparer.Value,
                addAssignCheckedComparer.Value,
                addCheckedComparer.Value,
                andComparer.Value,
                andAlsoComparer.Value,
                andAssignComparer.Value,
                arrayIndexComparer.Value,
                arrayLengthComparer.Value,
                assignComparer.Value,
                blockComparer.Value,
                callComparer.Value,
                coalesceComparer.Value,
                conditionalComparer.Value,
                constantComparer.Value,
                convertMethodComparer.Value,
                convertOperandComparer.Value,
                convertCheckedMethodComparer.Value,
                convertCheckedOperandComparer.Value,
                debugInfoComparer.Value,
                decrementMethodComparer.Value,
                decrementOperandComparer.Value,
                divideComparer.Value,
                divideAssignComparer.Value,
                dynamicComparer.Value,
                equalComparer.Value,
                exclusiveOrComparer.Value,
                exclusiveOrAssignComparer.Value,
                gotoComparer.Value,
                greaterThanComparer.Value,
                greaterThanOrEqualComparer.Value,
                incrementMethodComparer.Value,
                incrementOperandComparer.Value,
                indexComparer.Value,
                invokeComparer.Value,
                isFalseMethodComparer.Value,
                isFalseOperandComparer.Value,
                isTrueMethodComparer.Value,
                isTrueOperandComparer.Value,
                labelComparer.Value,
                lambdaComparer.Value,
                leftShiftComparer.Value,
                leftShiftAssignComparer.Value,
                lessThanComparer.Value,
                lessThanOrEqualComparer.Value,
                listInitComparer.Value,
                loopComparer.Value,
                memberAccessComparer.Value,
                memberInitComparer.Value,
                moduloComparer.Value,
                moduloAssignComparer.Value,
                multiplyComparer.Value,
                multiplyAssignComparer.Value,
                multiplyAssignCheckedComparer.Value,
                multiplyCheckedComparer.Value,
                negateMethodComparer.Value,
                negateOperandComparer.Value,
                negateCheckedMethodComparer.Value,
                negateCheckedOperandComparer.Value,
                newComparer.Value,
                newArrayBoundsComparer.Value,
                newArrayInitComparer.Value,
                notMethodComparer.Value,
                notOperandComparer.Value,
                notEqualComparer.Value,
                onesComplementMethodComparer.Value,
                onesComplementOperandComparer.Value,
                orComparer.Value,
                orAssignComparer.Value,
                orElseComparer.Value,
                parameterComparer.Value,
                postDecrementAssignMethodComparer.Value,
                postDecrementAssignOperandComparer.Value,
                postIncrementAssignMethodComparer.Value,
                postIncrementAssignOperandComparer.Value,
                powerComparer.Value,
                powerAssignComparer.Value,
                preDecrementAssignMethodComparer.Value,
                preDecrementAssignOperandComparer.Value,
                preIncrementAssignMethodComparer.Value,
                preIncrementAssignOperandComparer.Value,
                quoteComparer.Value,
                rightShiftComparer.Value,
                rightShiftAssignComparer.Value,
                runtimeVariablesComparer.Value,
                subtractComparer.Value,
                subtractAssignComparer.Value,
                subtractAssignCheckedComparer.Value,
                subtractCheckedComparer.Value,
                switchComparer.Value,
                throwComparer.Value,
                tryComparer.Value,
                typeAsComparer.Value,
                typeEqualComparer.Value,
                typeIsComparer.Value,
                unaryPlusMethodComparer.Value,
                unaryPlusOperandComparer.Value,
                unboxMethodComparer.Value,
                unboxOperandComparer.Value
            }));

            #endregion Lazy initializers

            public IEnumerable<INodeComparer> ComparisonSemantics => allComparers.Value;

            #region Comparers for specific ExpressionType values

            public IEnumerable<INodeComparerForType> AddComparers => new[] { addComparer.Value };
            public IEnumerable<INodeComparerForType> AddAssignComparers => new[] { addAssignComparer.Value };
            public IEnumerable<INodeComparerForType> AddAssignCheckedComparers => new[] { addAssignCheckedComparer.Value };
            public IEnumerable<INodeComparerForType> AddCheckedComparers => new[] { addCheckedComparer.Value };
            public IEnumerable<INodeComparerForType> AndComparers => new[] { andComparer.Value };
            public IEnumerable<INodeComparerForType> AndAlsoComparers => new[] { andAlsoComparer.Value };
            public IEnumerable<INodeComparerForType> AndAssignComparers => new[] { andAssignComparer.Value };
            public IEnumerable<INodeComparerForType> ArrayIndexComparers => new[] { arrayIndexComparer.Value };
            public IEnumerable<INodeComparerForType> ArrayLengthComparers => new[] { arrayLengthComparer.Value };
            public IEnumerable<INodeComparerForType> AssignComparers => new[] { assignComparer.Value };
            public IEnumerable<INodeComparerForType> BlockComparers => new[] { blockComparer.Value };
            public IEnumerable<INodeComparerForType> CallComparers => new[] { callComparer.Value };
            public IEnumerable<INodeComparerForType> CoalesceComparers => new[] { coalesceComparer.Value };
            public IEnumerable<INodeComparerForType> ConditionalComparers => new[] { conditionalComparer.Value };
            public IEnumerable<INodeComparerForType> ConstantComparers => new[] { constantComparer.Value };
            public IEnumerable<INodeComparerForType> ConvertComparers => new[] { convertMethodComparer.Value, convertOperandComparer.Value };
            public IEnumerable<INodeComparerForType> ConvertCheckedComparers => new[] { convertCheckedMethodComparer.Value, convertCheckedOperandComparer.Value };
            public IEnumerable<INodeComparerForType> DebugInfoComparers => new[] { debugInfoComparer.Value };
            public IEnumerable<INodeComparer> UniversalComparers { get; }
            public IEnumerable<INodeComparerForType> DecrementComparers => new[] { decrementMethodComparer.Value, decrementOperandComparer.Value };
            public IEnumerable<INodeComparerForType> DivideComparers => new[] { divideComparer.Value };
            public IEnumerable<INodeComparerForType> DivideAssignComparers => new[] { divideAssignComparer.Value };
            public IEnumerable<INodeComparerForType> DynamicComparers => new[] { dynamicComparer.Value };
            public IEnumerable<INodeComparerForType> EqualComparers => new[] { equalComparer.Value };
            public IEnumerable<INodeComparerForType> ExclusiveOrComparers => new[] { exclusiveOrComparer.Value };
            public IEnumerable<INodeComparerForType> ExclusiveOrAssignComparers => new[] { exclusiveOrAssignComparer.Value };
            public IEnumerable<INodeComparerForType> ExtensionComparers => new INodeComparerForType[0];
            public IEnumerable<INodeComparerForType> GotoComparers => new[] { gotoComparer.Value };
            public IEnumerable<INodeComparerForType> GreaterThanComparers => new[] { greaterThanComparer.Value };
            public IEnumerable<INodeComparerForType> GreaterThanOrEqualComparers => new[] { greaterThanOrEqualComparer.Value };
            public IEnumerable<INodeComparerForType> IncrementComparers => new[] { incrementMethodComparer.Value, incrementOperandComparer.Value };
            public IEnumerable<INodeComparerForType> IndexComparers => new[] { indexComparer.Value };
            public IEnumerable<INodeComparerForType> InvokeComparers => new[] { invokeComparer.Value };
            public IEnumerable<INodeComparerForType> IsFalseComparers => new[] { isFalseMethodComparer.Value, isFalseOperandComparer.Value };
            public IEnumerable<INodeComparerForType> IsTrueComparers => new[] { isTrueMethodComparer.Value, isTrueOperandComparer.Value };
            public IEnumerable<INodeComparerForType> LabelComparers => new[] { labelComparer.Value };
            public IEnumerable<INodeComparerForType> LambdaComparers => new[] { lambdaComparer.Value };
            public IEnumerable<INodeComparerForType> LeftShiftComparers => new[] { leftShiftComparer.Value };
            public IEnumerable<INodeComparerForType> LeftShiftAssignComparers => new[] { leftShiftAssignComparer.Value };
            public IEnumerable<INodeComparerForType> LessThanComparers => new[] { lessThanComparer.Value };
            public IEnumerable<INodeComparerForType> LessThanLessThanOrEqualComparers => new[] { lessThanOrEqualComparer.Value };
            public IEnumerable<INodeComparerForType> ListInitComparers => new[] { listInitComparer.Value };
            public IEnumerable<INodeComparerForType> LoopComparers => new[] { loopComparer.Value };
            public IEnumerable<INodeComparerForType> MemberAccessComparers => new[] { memberAccessComparer.Value };
            public IEnumerable<INodeComparerForType> MemberInitComparers => new[] { memberInitComparer.Value };
            public IEnumerable<INodeComparerForType> ModuloComparers => new[] { moduloComparer.Value };
            public IEnumerable<INodeComparerForType> ModuloAssignComparers => new[] { moduloAssignComparer.Value };
            public IEnumerable<INodeComparerForType> MultiplyComparers => new[] { multiplyComparer.Value };
            public IEnumerable<INodeComparerForType> MultiplyAssignComparers => new[] { multiplyAssignComparer.Value };
            public IEnumerable<INodeComparerForType> MultiplyAssignCheckedComparers => new[] { multiplyAssignCheckedComparer.Value };
            public IEnumerable<INodeComparerForType> MultiplyCheckedComparers => new[] { multiplyCheckedComparer.Value };
            public IEnumerable<INodeComparerForType> NegateComparers => new[] { negateMethodComparer.Value, negateOperandComparer.Value };
            public IEnumerable<INodeComparerForType> NegateCheckedComparers => new[] { negateCheckedMethodComparer.Value, negateCheckedOperandComparer.Value };
            public IEnumerable<INodeComparerForType> NewComparers => new[] { newComparer.Value };
            public IEnumerable<INodeComparerForType> NewArrayBoundsComparers => new[] { newArrayBoundsComparer.Value };
            public IEnumerable<INodeComparerForType> NewArrayInitComparers => new[] { newArrayInitComparer.Value };
            public IEnumerable<INodeComparerForType> NotComparers => new[] { notMethodComparer.Value, notOperandComparer.Value };
            public IEnumerable<INodeComparerForType> NotEqualComparers => new[] { notEqualComparer.Value };
            public IEnumerable<INodeComparerForType> OnesComplementComparers => new[] { onesComplementMethodComparer.Value, onesComplementOperandComparer.Value };
            public IEnumerable<INodeComparerForType> OrComparers => new[] { orComparer.Value };
            public IEnumerable<INodeComparerForType> OrAssignComparers => new[] { orAssignComparer.Value };
            public IEnumerable<INodeComparerForType> OrElseComparers => new[] { orElseComparer.Value };
            public IEnumerable<INodeComparerForType> ParameterComparers => new[] { parameterComparer.Value };
            public IEnumerable<INodeComparerForType> PostDecrementAssignComparers => new[] { postDecrementAssignMethodComparer.Value, postDecrementAssignOperandComparer.Value };
            public IEnumerable<INodeComparerForType> PostIncrementAssignComparers => new[] { postIncrementAssignMethodComparer.Value, postIncrementAssignOperandComparer.Value };
            public IEnumerable<INodeComparerForType> PowerComparers => new[] { powerComparer.Value };
            public IEnumerable<INodeComparerForType> PowerAssignComparers => new[] { powerAssignComparer.Value };
            public IEnumerable<INodeComparerForType> PreDecrementAssignComparers => new[] { preDecrementAssignMethodComparer.Value, preDecrementAssignOperandComparer.Value };
            public IEnumerable<INodeComparerForType> PreIncrementAssignComparers => new[] { preIncrementAssignMethodComparer.Value, preIncrementAssignOperandComparer.Value };
            public IEnumerable<INodeComparerForType> QuoteComparers => new[] { quoteComparer.Value };
            public IEnumerable<INodeComparerForType> RightShiftComparers => new[] { rightShiftComparer.Value };
            public IEnumerable<INodeComparerForType> RightShiftAssignComparers => new[] { rightShiftAssignComparer.Value };
            public IEnumerable<INodeComparerForType> RuntimeVariablesComparers => new[] { runtimeVariablesComparer.Value };
            public IEnumerable<INodeComparerForType> SubtractComparers => new[] { subtractComparer.Value };
            public IEnumerable<INodeComparerForType> SubtractAssignComparers => new[] { subtractAssignComparer.Value };
            public IEnumerable<INodeComparerForType> SubtractAssignCheckedComparers => new[] { subtractAssignCheckedComparer.Value };
            public IEnumerable<INodeComparerForType> SubtractCheckedComparers => new[] { subtractCheckedComparer.Value };
            public IEnumerable<INodeComparerForType> SwitchComparers => new[] { switchComparer.Value };
            public IEnumerable<INodeComparerForType> ThrowComparers => new[] { throwComparer.Value };
            public IEnumerable<INodeComparerForType> TryComparers => new[] { tryComparer.Value };
            public IEnumerable<INodeComparerForType> TypeAsComparers => new[] { typeAsComparer.Value };
            public IEnumerable<INodeComparerForType> TypeEqualComparers => new[] { typeEqualComparer.Value };
            public IEnumerable<INodeComparerForType> TypeIsComparers => new[] { typeIsComparer.Value };
            public IEnumerable<INodeComparerForType> UnaryPlusComparers => new[] { unaryPlusMethodComparer.Value, unaryPlusOperandComparer.Value };
            public IEnumerable<INodeComparerForType> UnboxComparers => new[] { unboxMethodComparer.Value, unboxOperandComparer.Value };

            #endregion Comparers for specific ExpressionType values

            #region Comparers for related non-expression types

            public IMemberBindingComparer MemberBindingComparer => memberBindingComparer.Value;
            public ISwitchCaseComparer SwitchCaseComparer => switchCaseComparer.Value;

            #endregion Comparers for related non-expression types
        }
    }
}
