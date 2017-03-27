using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Legacy.Core;
using Legacy.Core.Composition;

namespace Legacy.ExtensionMethods
{
    public static partial class ExpressionComposer
    {
        public static Func<IManipulationUnit, IManipulationUnit, LambdaExpression, IManipulationUnit> ComposeBinary { get; set; } = (left, right, lambda) => new BinaryComposer(left, right, lambda);
        
        private static LambdaExpression MakeBinary(ExpressionType operationType, ParameterExpression leftPlaceholder, ParameterExpression rightPlaceholder, IEnumerable<ParameterExpression> innerParameters) => Expression.Lambda(Expression.Quote(Expression.Lambda(Expression.MakeBinary(operationType, leftPlaceholder, rightPlaceholder), innerParameters)), leftPlaceholder, rightPlaceholder);
        
        #region Bind methods
        
        public static IManipulationOfAction Bind<TOut1, TOut2>(this IManipulationOfFunc<TOut1> left, Expression<Func<TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TResult> Bind<TOut1, TOut2, TResult>(this IManipulationOfFunc<TOut1> left, Expression<Func<TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction Bind<TOut1, TOut2>(this IManipulationOfFunc<TOut1> left, IManipulationOfFunc<TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TResult> Bind<TOut1, TOut2, TResult>(this IManipulationOfFunc<TOut1> left, IManipulationOfFunc<TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction Bind<TOut1, TOut2>(this IBinaryComposer<TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TResult> Bind<TOut1, TOut2, TResult>(this IBinaryComposer<TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1> Bind<TIn1, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TOut1> left, Expression<Func<TIn1, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TResult> Bind<TIn1, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TOut1> left, Expression<Func<TIn1, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1> Bind<TIn1, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TOut1> left, IManipulationOfFunc<TIn1, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TResult> Bind<TIn1, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TOut1> left, IManipulationOfFunc<TIn1, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1> Bind<TIn1, TOut1, TOut2>(this IBinaryComposer<TIn1, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TResult> Bind<TIn1, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2> Bind<TIn1, TIn2, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TOut1> left, Expression<Func<TIn1, TIn2, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TResult> Bind<TIn1, TIn2, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TOut1> left, Expression<Func<TIn1, TIn2, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2> Bind<TIn1, TIn2, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TResult> Bind<TIn1, TIn2, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2> Bind<TIn1, TIn2, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TResult> Bind<TIn1, TIn2, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3> Bind<TIn1, TIn2, TIn3, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> Bind<TIn1, TIn2, TIn3, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3> Bind<TIn1, TIn2, TIn3, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> Bind<TIn1, TIn2, TIn3, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3> Bind<TIn1, TIn2, TIn3, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> Bind<TIn1, TIn2, TIn3, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> Bind<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> Bind<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> Bind<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut2>> right, Expression<Action<TOut1, TOut2>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1> left, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut2>> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => Bind(left, ExpressionEngine.CreateManipulationUnitForFunc(right), bindingFunction);
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut2> right, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2, TResult>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut2> right, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(ComposeBinary(left, right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2> sourceUnits, Expression<Action<TOut1, TOut2>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Bind<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2, TResult>(this IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2> sourceUnits, Expression<Func<TOut1, TOut2, TResult>> bindingFunction) => ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(ComposeBinary(sourceUnits.Left, sourceUnits.Right, Expression.Lambda(Expression.Quote(Expression.Lambda(bindingFunction.Body, sourceUnits.Left.Parameters)), bindingFunction.Parameters)));
        
        #endregion Bind methods
        
        #region Logical methods
        
        public static IManipulationOfFunc<bool> AndAlso(this IManipulationOfFunc<bool> source, params IManipulationOfFunc<bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<bool>(aggregator);
        }
        
        public static IManipulationOfFunc<bool> OrElse(this IManipulationOfFunc<bool> source, params IManipulationOfFunc<bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, bool> AndAlso<TIn1>(this IManipulationOfFunc<TIn1, bool> source, params IManipulationOfFunc<TIn1, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, bool> OrElse<TIn1>(this IManipulationOfFunc<TIn1, bool> source, params IManipulationOfFunc<TIn1, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, bool> AndAlso<TIn1, TIn2>(this IManipulationOfFunc<TIn1, TIn2, bool> source, params IManipulationOfFunc<TIn1, TIn2, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, bool> OrElse<TIn1, TIn2>(this IManipulationOfFunc<TIn1, TIn2, bool> source, params IManipulationOfFunc<TIn1, TIn2, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, bool> AndAlso<TIn1, TIn2, TIn3>(this IManipulationOfFunc<TIn1, TIn2, TIn3, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, bool> OrElse<TIn1, TIn2, TIn3>(this IManipulationOfFunc<TIn1, TIn2, TIn3, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, bool> AndAlso<TIn1, TIn2, TIn3, TIn4>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, bool> OrElse<TIn1, TIn2, TIn3, TIn4>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, bool>(aggregator);
        }

        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, bool> AndAlso<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.AndAlso, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, bool>(aggregator);
        }
        
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, bool> OrElse<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, bool> source, params IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, bool>[] additionalConditions)
        {
            var aggregator = source as IManipulationUnit;
            foreach (var condition in additionalConditions)
                aggregator = ComposeBinary(aggregator, condition, MakeBinary(ExpressionType.OrElse, Expression.Parameter(typeof(bool)), Expression.Parameter(typeof(bool)), source.Parameters));
            
            return ExpressionEngine.CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, bool>(aggregator);
        }
        
        #endregion Logical methods
    }
}