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
    /// 
    /// </summary>
    public interface IVoidChainBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IVoidChainBuilder Add(IVoidLink link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder Add(ICan cando, IVoidDo voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder Add(Func<bool> cando, Action voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IVoidChain Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    public interface IVoidChainBuilder<T1>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1> Add(IVoidLink<T1> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1> Add(ICan<T1> cando, IVoidDo<T1> voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1> Add(Func<T1, bool> cando, Action<T1> voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IVoidChain<T1> Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public interface IVoidChainBuilder<T1, T2>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2> Add(IVoidLink<T1, T2> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2> Add(ICan<T1, T2> cando, IVoidDo<T1, T2> voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2> Add(Func<T1, T2, bool> cando, Action<T1, T2> voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IVoidChain<T1, T2> Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    public interface IVoidChainBuilder<T1, T2, T3>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2, T3> Add(IVoidLink<T1, T2, T3> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2, T3> Add(ICan<T1, T2, T3> cando, IVoidDo<T1, T2, T3> voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2, T3> Add(Func<T1, T2, T3, bool> cando, Action<T1, T2, T3> voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IVoidChain<T1, T2, T3> Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    public interface IVoidChainBuilder<T1, T2, T3, T4>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2, T3, T4> Add(IVoidLink<T1, T2, T3, T4> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2, T3, T4> Add(ICan<T1, T2, T3, T4> cando, IVoidDo<T1, T2, T3, T4> voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2, T3, T4> Add(Func<T1, T2, T3, T4, bool> cando, Action<T1, T2, T3, T4> voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IVoidChain<T1, T2, T3, T4> Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    public interface IVoidChainBuilder<T1, T2, T3, T4, T5>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2, T3, T4, T5> Add(IVoidLink<T1, T2, T3, T4, T5> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2, T3, T4, T5> Add(ICan<T1, T2, T3, T4, T5> cando, IVoidDo<T1, T2, T3, T4, T5> voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        IVoidChainBuilder<T1, T2, T3, T4, T5> Add(Func<T1, T2, T3, T4, T5, bool> cando, Action<T1, T2, T3, T4, T5> voidDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IVoidChain<T1, T2, T3, T4, T5> Build();
    }

    #endregion

    #region Result

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChainBuilder<TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IResultChainBuilder<TResult> Add(IResultLink<TResult> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<TResult> Add(ICan cando, IResultDo<TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<TResult> Add(Func<bool> cando, Func<TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IResultChain<TResult> Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChainBuilder<T1, TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, TResult> Add(IResultLink<T1, TResult> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, TResult> Add(ICan<T1> cando, IResultDo<T1, TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, TResult> Add(Func<T1, bool> cando, Func<T1, TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IResultChain<T1, TResult> Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChainBuilder<T1, T2, TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, TResult> Add(IResultLink<T1, T2, TResult> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, TResult> Add(ICan<T1, T2> cando, IResultDo<T1, T2, TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, TResult> Add(Func<T1, T2, bool> cando, Func<T1, T2, TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IResultChain<T1, T2, TResult> Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChainBuilder<T1, T2, T3, TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, T3, TResult> Add(IResultLink<T1, T2, T3, TResult> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, T3, TResult> Add(ICan<T1, T2, T3> cando, IResultDo<T1, T2, T3, TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, T3, TResult> Add(Func<T1, T2, T3, bool> cando, Func<T1, T2, T3, TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IResultChain<T1, T2, T3, TResult> Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChainBuilder<T1, T2, T3, T4, TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, T3, T4, TResult> Add(IResultLink<T1, T2, T3, T4, TResult> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, T3, T4, TResult> Add(ICan<T1, T2, T3, T4> cando, IResultDo<T1, T2, T3, T4, TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, T3, T4, TResult> Add(Func<T1, T2, T3, T4, bool> cando, Func<T1, T2, T3, T4, TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IResultChain<T1, T2, T3, T4, TResult> Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChainBuilder<T1, T2, T3, T4, T5, TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(IResultLink<T1, T2, T3, T4, T5, TResult> link);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(ICan<T1, T2, T3, T4, T5> cando, IResultDo<T1, T2, T3, T4, T5, TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(Func<T1, T2, T3, T4, T5, bool> cando, Func<T1, T2, T3, T4, T5, TResult> resultDo);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IResultChain<T1, T2, T3, T4, T5, TResult> Build();
    }

    #endregion
}
