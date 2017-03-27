using System;
using System.Linq.Expressions;
using System.Collections.ObjectModel;
using Legacy.Core;
using Legacy.Core.Composition;
using Legacy.Core.Reduction;

namespace Legacy.Source
{
    public interface IManipulationSource<TResult> : IUnitHolder { Expression<Func<TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TResult> : IUnitHolder { Expression<Func<TIn1, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TResult>> Extract(); IManipulationSource<TIn1, TIn2, TOut> Create<TOut>(Expression<Func<TIn1, TIn2, TOut>> lambda); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>> Extract(); }

    public interface IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> : IUnitHolder { Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>> Extract(); }

    public static partial class ExpressionSource {
        public interface ISourceEngine
        {
            IManipulationUnit CreateBinary(IManipulationUnit left, IManipulationUnit right, LambdaExpression compositionFunction);

            IManipulationSource<TResult> Create<TResult>(Expression<Func<TResult>> lambda);
            IManipulationSource<TIn1, TResult> Create<TIn1, TResult>(Expression<Func<TIn1, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TResult> Create<TIn1, TIn2, TResult>(Expression<Func<TIn1, TIn2, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TResult> Create<TIn1, TIn2, TIn3, TResult>(Expression<Func<TIn1, TIn2, TIn3, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TResult> Create<TIn1, TIn2, TIn3, TIn4, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>> lambda);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>> lambda);

            IManipulationSource<TResult> Cast<TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TResult> Cast<TIn1, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TResult> Cast<TIn1, TIn2, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TResult> Cast<TIn1, TIn2, TIn3, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(IManipulationUnit source);
            IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(IManipulationUnit source);
        }

        private class SourceEngine : ISourceEngine
        {
            public IManipulationUnit CreateBinary(IManipulationUnit left, IManipulationUnit right, LambdaExpression compositionFunction) => new BinaryComposer(left, right, compositionFunction);

            public IManipulationSource<TResult> Create<TResult>(Expression<Func<TResult>> lambda) => new ManipulationSource<TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TResult> Create<TIn1, TResult>(Expression<Func<TIn1, TResult>> lambda) => new ManipulationSource<TIn1, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TResult> Create<TIn1, TIn2, TResult>(Expression<Func<TIn1, TIn2, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TResult> Create<TIn1, TIn2, TIn3, TResult>(Expression<Func<TIn1, TIn2, TIn3, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TResult> Create<TIn1, TIn2, TIn3, TIn4, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(new TrivialUnit(lambda));
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Create<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>> lambda) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(new TrivialUnit(lambda));

            public IManipulationSource<TResult> Cast<TResult>(IManipulationUnit source) => new ManipulationSource<TResult>(source);
            public IManipulationSource<TIn1, TResult> Cast<TIn1, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TResult> Cast<TIn1, TIn2, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TResult> Cast<TIn1, TIn2, TIn3, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>(source);
            public IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Cast<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(IManipulationUnit source) => new ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>(source);

            private class ManipulationSource<TOut> : IManipulationSource<TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TOut>> Extract() => (Expression<Func<TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TOut> : IManipulationSource<TIn1, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TOut>> Extract() => (Expression<Func<TIn1, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TOut> : IManipulationSource<TIn1, TIn2, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
                public IManipulationSource<TIn1, TIn2, TOut1> Create<TOut1>(Expression<Func<TIn1, TIn2, TOut1>> lambda)
                {
                    return null;
                }
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }

            private class ManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> : IManipulationSource<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>
            {
                private readonly IManipulationUnit composer;
                public ManipulationSource(IManipulationUnit unit)
                {
                    InnerUnit = unit;
                    Parameters = unit.Parameters;
                }
                
                public IManipulationUnit InnerUnit { get; }
                public LambdaExpression ExtractToLambda() => new TransparentIdentifierRemover(InnerUnit).ExtractToLambda();
                public ReadOnlyCollection<ParameterExpression> Parameters { get; }
                public ManipulationType UnitType => ManipulationType.UnitHolder;
                public Expression Extract(ReadOnlyCollection<ParameterExpression> parameters) => new TransparentIdentifierRemover(InnerUnit).Extract(parameters);
                public Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>> Extract() => (Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>>)(new TransparentIdentifierRemover(InnerUnit).ExtractToLambda());
            }
        }
    }
}