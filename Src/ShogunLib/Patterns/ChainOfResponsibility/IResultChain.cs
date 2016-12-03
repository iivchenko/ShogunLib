// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Chain of responsibility with output and no parameters.
    /// </summary>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChain<out TResult>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <returns>Chain handling result.</returns>
        TResult Execute();
    }

    /// <summary>
    /// Chain of responsibility with output and one parameter.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChain<in T1, out TResult>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <returns>Chain handling result.</returns>
        TResult Execute(T1 t1);
    }

    /// <summary>
    /// Chain of responsibility with output and two parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChain<in T1, in T2, out TResult>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <returns>Chain handling result.</returns>
        TResult Execute(T1 t1, T2 t2);
    }

    /// <summary>
    /// Chain of responsibility with output and three parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChain<in T1, in T2, in T3, out TResult>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        /// <returns>Chain handling result.</returns>
        TResult Execute(T1 t1, T2 t2, T3 t3);
    }

    /// <summary>
    /// Chain of responsibility with output and four parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChain<in T1, in T2, in T3, in T4, out TResult>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        /// <param name="t4">Fourth input parameter of a chain.</param>
        /// <returns>Chain handling result.</returns>
        TResult Execute(T1 t1, T2 t2, T3 t3, T4 t4);
    }

    /// <summary>
    /// Chain of responsibility with output and five parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of chain fifth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public interface IResultChain<in T1, in T2, in T3, in T4, in T5, out TResult>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        /// <param name="t4">Fourth input parameter of a chain.</param>
        /// <param name="t5">Fifth input parameter of a chain.</param>
        /// <returns>Chain handling result.</returns>
        TResult Execute(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
    }
}
