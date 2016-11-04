// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    #region Void 

    /// <summary>
    /// Provides functionality to configure new chain with no output and no parameters.
    /// </summary>
    public interface IVoidChainBuilder
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder Add(IVoidLink link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder Add(ICan cando, IVoidDo voidDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder Add(Func<bool> cando, Action voidDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IVoidChain Build();
    }

    /// <summary>
    /// Provides functionality to configure new chain with no output and one parameter.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    public interface IVoidChainBuilder<T1>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1> Add(IVoidLink<T1> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1> Add(ICan<T1> cando, IVoidDo<T1> voidDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1> Add(Func<T1, bool> cando, Action<T1> voidDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IVoidChain<T1> Build();
    }

    /// <summary>
    /// Provides functionality to configure new chain with no output and two parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    public interface IVoidChainBuilder<T1, T2>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2> Add(IVoidLink<T1, T2> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2> Add(ICan<T1, T2> cando, IVoidDo<T1, T2> voidDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2> Add(Func<T1, T2, bool> cando, Action<T1, T2> voidDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IVoidChain<T1, T2> Build();
    }

    /// <summary>
    /// Provides functionality to configure new chain with no output and three parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    public interface IVoidChainBuilder<T1, T2, T3>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2, T3> Add(IVoidLink<T1, T2, T3> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2, T3> Add(ICan<T1, T2, T3> cando, IVoidDo<T1, T2, T3> voidDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2, T3> Add(Func<T1, T2, T3, bool> cando, Action<T1, T2, T3> voidDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IVoidChain<T1, T2, T3> Build();
    }

    /// <summary>
    /// Provides functionality to configure new chain with no output and four parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    public interface IVoidChainBuilder<T1, T2, T3, T4>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2, T3, T4> Add(IVoidLink<T1, T2, T3, T4> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2, T3, T4> Add(ICan<T1, T2, T3, T4> cando, IVoidDo<T1, T2, T3, T4> voidDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2, T3, T4> Add(Func<T1, T2, T3, T4, bool> cando, Action<T1, T2, T3, T4> voidDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IVoidChain<T1, T2, T3, T4> Build();
    }

    /// <summary>
    /// Provides functionality to configure new chain with no output and five parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of chain fifth input parameter.</typeparam>
    public interface IVoidChainBuilder<T1, T2, T3, T4, T5>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2, T3, T4, T5> Add(IVoidLink<T1, T2, T3, T4, T5> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2, T3, T4, T5> Add(ICan<T1, T2, T3, T4, T5> cando, IVoidDo<T1, T2, T3, T4, T5> voidDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IVoidChainBuilder<T1, T2, T3, T4, T5> Add(Func<T1, T2, T3, T4, T5, bool> cando, Action<T1, T2, T3, T4, T5> voidDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IVoidChain<T1, T2, T3, T4, T5> Build();
    }

    #endregion

    #region Result

    /// <summary>
    /// Provides functionality to configure new chain with output and no parameters.
    /// </summary>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChainBuilder<TResult>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<TResult> Add(IResultLink<TResult> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<TResult> Add(ICan cando, IResultDo<TResult> resultDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<TResult> Add(Func<bool> cando, Func<TResult> resultDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IResultChain<TResult> Build();
    }

    /// <summary>
    /// Provides functionality to configure new chain with output and one parameter.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChainBuilder<T1, TResult>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, TResult> Add(IResultLink<T1, TResult> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, TResult> Add(ICan<T1> cando, IResultDo<T1, TResult> resultDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, TResult> Add(Func<T1, bool> cando, Func<T1, TResult> resultDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IResultChain<T1, TResult> Build();
    }

    /// <summary>
    /// Provides functionality to configure new chain with output and two parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChainBuilder<T1, T2, TResult>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, TResult> Add(IResultLink<T1, T2, TResult> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, TResult> Add(ICan<T1, T2> cando, IResultDo<T1, T2, TResult> resultDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, TResult> Add(Func<T1, T2, bool> cando, Func<T1, T2, TResult> resultDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IResultChain<T1, T2, TResult> Build();
    }

    /// <summary>
    /// Provides functionality to configure new chain with output and three parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChainBuilder<T1, T2, T3, TResult>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, T3, TResult> Add(IResultLink<T1, T2, T3, TResult> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, T3, TResult> Add(ICan<T1, T2, T3> cando, IResultDo<T1, T2, T3, TResult> resultDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, T3, TResult> Add(Func<T1, T2, T3, bool> cando, Func<T1, T2, T3, TResult> resultDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IResultChain<T1, T2, T3, TResult> Build();
    }

    /// <summary>
    /// Provides functionality to configure new chain with output and four parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChainBuilder<T1, T2, T3, T4, TResult>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, T3, T4, TResult> Add(IResultLink<T1, T2, T3, T4, TResult> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, T3, T4, TResult> Add(ICan<T1, T2, T3, T4> cando, IResultDo<T1, T2, T3, T4, TResult> resultDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, T3, T4, TResult> Add(Func<T1, T2, T3, T4, bool> cando, Func<T1, T2, T3, T4, TResult> resultDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IResultChain<T1, T2, T3, T4, TResult> Build();
    }

    /// <summary>
    /// Provides functionality to configure new chain with output and five parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of chain fifth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChainBuilder<T1, T2, T3, T4, T5, TResult>
    {
        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(IResultLink<T1, T2, T3, T4, T5, TResult> link);

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(ICan<T1, T2, T3, T4, T5> cando, IResultDo<T1, T2, T3, T4, T5, TResult> resultDo);

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(Func<T1, T2, T3, T4, T5, bool> cando, Func<T1, T2, T3, T4, T5, TResult> resultDo);

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        IResultChain<T1, T2, T3, T4, T5, TResult> Build();
    }

    #endregion
}
