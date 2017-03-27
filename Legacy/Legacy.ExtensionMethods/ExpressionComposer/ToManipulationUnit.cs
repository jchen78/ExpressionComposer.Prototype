using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Legacy.Core;

namespace Legacy.ExtensionMethods
{
    public static partial class ExpressionComposer
    {
        public static IExpressionEngine ExpressionEngine { get; set; } = new TrivialExpressionEngine();

        public static IManipulationOfAction ToUnit(Expression<Action> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TResult> ToUnit<TResult>(Expression<Func<TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1> ToUnit<TIn1>(Expression<Action<TIn1>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TResult> ToUnit<TIn1, TResult>(Expression<Func<TIn1, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2> ToUnit<TIn1, TIn2>(Expression<Action<TIn1, TIn2>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TResult> ToUnit<TIn1, TIn2, TResult>(Expression<Func<TIn1, TIn2, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3> ToUnit<TIn1, TIn2, TIn3>(Expression<Action<TIn1, TIn2, TIn3>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> ToUnit<TIn1, TIn2, TIn3, TResult>(Expression<Func<TIn1, TIn2, TIn3, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> ToUnit<TIn1, TIn2, TIn3, TIn4>(Expression<Action<TIn1, TIn2, TIn3, TIn4>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        public static IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForAction(sourceExpression);
        public static IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>> sourceExpression) => ExpressionEngine.CreateManipulationUnitForFunc(sourceExpression);

        private partial class TrivialExpressionEngine : IExpressionEngine
        {
            public IManipulationOfAction CreateManipulationUnitForAction(Expression<Action> sourceExpression) => new ComposerHolderForAction(new TrivialUnit(sourceExpression));
            public IManipulationOfAction CreateManipulationUnitForAction(IManipulationUnit sourceUnit) => new ComposerHolderForAction(sourceUnit);
            public IManipulationOfFunc<TResult> CreateManipulationUnitForFunc<TResult>(Expression<Func<TResult>> sourceExpression) => new ComposerHolderForFunc<TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TResult> CreateManipulationUnitForFunc<TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TResult>(sourceUnit);

            public IManipulationOfAction<TIn1> CreateManipulationUnitForAction<TIn1>(Expression<Action<TIn1>> sourceExpression) => new ComposerHolderForAction<TIn1>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1> CreateManipulationUnitForAction<TIn1>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1>(sourceUnit);
            public IManipulationOfFunc<TIn1, TResult> CreateManipulationUnitForFunc<TIn1, TResult>(Expression<Func<TIn1, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TResult> CreateManipulationUnitForFunc<TIn1, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2> CreateManipulationUnitForAction<TIn1, TIn2>(Expression<Action<TIn1, TIn2>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2> CreateManipulationUnitForAction<TIn1, TIn2>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TResult>(Expression<Func<TIn1, TIn2, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3> CreateManipulationUnitForAction<TIn1, TIn2, TIn3>(Expression<Action<TIn1, TIn2, TIn3>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3> CreateManipulationUnitForAction<TIn1, TIn2, TIn3>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TResult>(Expression<Func<TIn1, TIn2, TIn3, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4>(Expression<Action<TIn1, TIn2, TIn3, TIn4>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(sourceUnit);

            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>> sourceExpression) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(new TrivialUnit(sourceExpression));
            public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(IManipulationUnit sourceUnit) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(sourceUnit);
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>> sourceExpression) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(new TrivialUnit(sourceExpression));
            public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(IManipulationUnit sourceUnit) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(sourceUnit);

            #region ComposerHolderForAction

            private class ComposerHolderForAction : IManipulationOfAction
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action> Extract() => (Expression<Action>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1> : IManipulationOfAction<TIn1>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1>> Extract() => (Expression<Action<TIn1>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2> : IManipulationOfAction<TIn1, TIn2>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2>> Extract() => (Expression<Action<TIn1, TIn2>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3> : IManipulationOfAction<TIn1, TIn2, TIn3>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3>> Extract() => (Expression<Action<TIn1, TIn2, TIn3>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>>)InnerUnit.ExtractToLambda();
            }

            private class ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> : IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>
            {
                public ComposerHolderForAction(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>> Extract() => (Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>>)InnerUnit.ExtractToLambda();
            }

            #endregion ComposerHolderForAction

            #region ComposerHolderForFunc

            private class ComposerHolderForFunc<TOut> : IManipulationOfFunc<TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TOut>> Extract() => (Expression<Func<TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction Extend(Expression<Func<TOut, Expression<Action>>> compositionFunction) => new ComposerHolderForAction(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TResult>>>> compositionFunction) => new ComposerHolderForFunc<TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TOut> : IManipulationOfFunc<TIn1, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TOut>> Extract() => (Expression<Func<TIn1, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1> Extend(Expression<Func<TOut, Expression<Action<TIn1>>>> compositionFunction) => new ComposerHolderForAction<TIn1>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TOut> : IManipulationOfFunc<TIn1, TIn2, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            private class ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> : IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>
            {
                private readonly IManipulationUnit composer;
                public ComposerHolderForFunc(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => InnerUnit.ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => InnerUnit.Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>>)InnerUnit.ExtractToLambda();
                
                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>>>> compositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(ComposeUnary(InnerUnit, compositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>>>> compositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(ComposeUnary(InnerUnit, compositionFunction));
            }

            #endregion ComposerHolderForFunc

        }
    }

    public partial interface IExpressionEngine
    {
        IManipulationOfAction CreateManipulationUnitForAction(Expression<Action> sourceExpression);
        IManipulationOfAction CreateManipulationUnitForAction(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TResult> CreateManipulationUnitForFunc<TResult>(Expression<Func<TResult>> sourceExpression);
        IManipulationOfFunc<TResult> CreateManipulationUnitForFunc<TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1> CreateManipulationUnitForAction<TIn1>(Expression<Action<TIn1>> sourceExpression);
        IManipulationOfAction<TIn1> CreateManipulationUnitForAction<TIn1>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TResult> CreateManipulationUnitForFunc<TIn1, TResult>(Expression<Func<TIn1, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TResult> CreateManipulationUnitForFunc<TIn1, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2> CreateManipulationUnitForAction<TIn1, TIn2>(Expression<Action<TIn1, TIn2>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2> CreateManipulationUnitForAction<TIn1, TIn2>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TResult>(Expression<Func<TIn1, TIn2, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3> CreateManipulationUnitForAction<TIn1, TIn2, TIn3>(Expression<Action<TIn1, TIn2, TIn3>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3> CreateManipulationUnitForAction<TIn1, TIn2, TIn3>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TResult>(Expression<Func<TIn1, TIn2, TIn3, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4>(Expression<Action<TIn1, TIn2, TIn3, TIn4>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(IManipulationUnit sourceUnit);

        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>> sourceExpression);
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> CreateManipulationUnitForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(IManipulationUnit sourceUnit);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>> sourceExpression);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> CreateManipulationUnitForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(IManipulationUnit sourceUnit);
    }
}