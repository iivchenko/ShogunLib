// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    #region Void 

    /// <summary>
    /// 
    /// </summary>
    public interface IVoidChain
    {
        /// <summary>
        /// 
        /// </summary>
        void Execute();
    }
   
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    public interface IVoidChain<in T1>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        void Execute(T1 t1);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public interface IVoidChain<in T1, in T2>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        void Execute(T1 t1, T2 t2);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    public interface IVoidChain<in T1, in T2, in T3>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        void Execute(T1 t1, T2 t2, T3 t3);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    public interface IVoidChain<in T1, in T2, in T3, in T4>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        void Execute(T1 t1, T2 t2, T3 t3, T4 t4);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    public interface IVoidChain<in T1, in T2, in T3, in T4, in T5>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <param name="t5"></param>
        void Execute(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
    }

    #endregion

    #region Result

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChain<out TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        TResult Execute();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChain<in T1, out TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <returns></returns>
        TResult Execute(T1 t1);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChain<in T1, in T2, out TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        TResult Execute(T1 t1, T2 t2);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChain<in T1, in T2, in T3, out TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <returns></returns>
        TResult Execute(T1 t1, T2 t2, T3 t3);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultChain<in T1, in T2, in T3, in T4, out TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <returns></returns>
        TResult Execute(T1 t1, T2 t2, T3 t3, T4 t4);
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
    public interface IResultChain<in T1, in T2, in T3, in T4, in T5, out TResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <param name="t5"></param>
        /// <returns></returns>
        TResult Execute(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
    }

    #endregion
}
