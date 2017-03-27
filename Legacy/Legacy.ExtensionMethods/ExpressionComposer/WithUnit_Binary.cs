using System;
using System.Linq.Expressions;
using Legacy.Core.Composition;

namespace Legacy.ExtensionMethods
{
    public static partial class ExpressionComposer
    {
        #region WithUnit methods

        public static IBinaryComposer<TOut1, TOut2> WithUnit<TOut1, TOut2>(this IManipulationOfFunc<TOut1> left, IManipulationOfFunc<TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TOut1, TOut2> WithUnit<TIn1, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TOut1> left, IManipulationOfFunc<TIn1, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TOut1, TOut2> WithUnit<TIn1, TIn2, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        public static IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2> WithUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2>(this IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut2> right) => ExpressionEngine.CreateBinaryHolderWith(left, right);

        #endregion WithUnit methods

        private partial class TrivialExpressionEngine
        {
            public IBinaryComposer<TOut1, TOut2> CreateBinaryHolderWith<TOut1, TOut2>(IManipulationOfFunc<TOut1> left, IManipulationOfFunc<TOut2> right) => new BinaryHolder<TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TOut1, TOut2>(IManipulationOfFunc<TIn1, TOut1> left, IManipulationOfFunc<TIn1, TOut2> right) => new BinaryHolder<TIn1, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TOut2> right) => new BinaryHolder<TIn1, TIn2, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2>(left, right);
            public IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut2> right) => new BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2>(left, right);
            
            #region Binary holder classes

            private class BinaryHolder<TOut1, TOut2> : IBinaryComposer<TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TOut1> left, IManipulationOfFunc<TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TOut1> Left { get; }
                public IManipulationOfFunc<TOut2> Right { get; }

                public IManipulationOfAction Extend(Expression<Func<TOut1, TOut2, Expression<Action>>> curriedCompositionFunction) => new ComposerHolderForAction(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TOut1, TOut2> : IBinaryComposer<TIn1, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TOut1> left, IManipulationOfFunc<TIn1, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TOut2> Right { get; }

                public IManipulationOfAction<TIn1> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            private class BinaryHolder<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2> : IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2>
            {
                public BinaryHolder(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut2> right)
                {
                    Left = left;
                    Right = right;
                }

                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1> Left { get; }
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut2> Right { get; }

                public IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>>>> curriedCompositionFunction) => new ComposerHolderForAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>(new BinaryComposer(Left, Right, curriedCompositionFunction));
                public IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>>>> curriedCompositionFunction) => new ComposerHolderForFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(new BinaryComposer(Left, Right, curriedCompositionFunction));
            }

            #endregion Binary holder classes

        }

    }
    
    public partial interface IExpressionEngine
    {
        IBinaryComposer<TOut1, TOut2> CreateBinaryHolderWith<TOut1, TOut2>(IManipulationOfFunc<TOut1> left, IManipulationOfFunc<TOut2> right);
        IBinaryComposer<TIn1, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TOut1, TOut2>(IManipulationOfFunc<TIn1, TOut1> left, IManipulationOfFunc<TIn1, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut2> right);
        IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2> CreateBinaryHolderWith<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2>(IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1> left, IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut2> right);
    }
}