using System;
using System.Linq.Expressions;
using Legacy.Core;

namespace Legacy.ExtensionMethods
{
    public interface IManipulationOfAction : IUnitHolder { Expression<Action> Extract(); }
    public interface IManipulationOfFunc<TOut> : IUnitHolder
    {
        IManipulationOfAction Extend(Expression<Func<TOut, Expression<Action>>> curriedCompositionFunction);
        IManipulationOfFunc<TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TResult>>>> curriedCompositionFunction);
        Expression<Func<TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1> : IUnitHolder { Expression<Action<TIn1>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1> Extend(Expression<Func<TOut, Expression<Action<TIn1>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2> : IUnitHolder { Expression<Action<TIn1, TIn2>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut>> Extract();
    }

    public interface IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> : IUnitHolder { Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>> Extract(); }
    public interface IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut> : IUnitHolder
    {
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> Extend(Expression<Func<TOut, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Extend<TResult>(Expression<Func<TOut, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>>>> curriedCompositionFunction);
        Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut>> Extract();
    }

    public interface IBinaryComposer<TOut1, TOut2>
    {
        IManipulationOfFunc<TOut1> Left { get; }
        IManipulationOfFunc<TOut2> Right { get; }
        IManipulationOfAction Extend(Expression<Func<TOut1, TOut2, Expression<Action>>> curriedCompositionFunction);
        IManipulationOfFunc<TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TOut2> Right { get; }
        IManipulationOfAction<TIn1> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TResult>>>> curriedCompositionFunction);
    }

    public interface IBinaryComposer<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1, TOut2>
    {
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut1> Left { get; }
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TOut2> Right { get; }
        IManipulationOfAction<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16> Extend(Expression<Func<TOut1, TOut2, Expression<Action<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16>>>> curriedCompositionFunction);
        IManipulationOfFunc<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult> Extend<TResult>(Expression<Func<TOut1, TOut2, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TIn9, TIn10, TIn11, TIn12, TIn13, TIn14, TIn15, TIn16, TResult>>>> curriedCompositionFunction);
    }
}