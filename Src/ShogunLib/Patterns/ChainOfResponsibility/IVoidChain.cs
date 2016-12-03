// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Chain of responsibility with no output and no parameters.
    /// </summary>
    public interface IVoidChain
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        void Execute();
    }

    /// <summary>
    /// Chain of responsibility with no output and one parameter.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    public interface IVoidChain<in T1>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        void Execute(T1 t1);
    }

    /// <summary>
    /// Chain of responsibility with no output and two parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    public interface IVoidChain<in T1, in T2>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        void Execute(T1 t1, T2 t2);
    }

    /// <summary>
    /// Chain of responsibility with no output and three parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    public interface IVoidChain<in T1, in T2, in T3>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        void Execute(T1 t1, T2 t2, T3 t3);
    }

    /// <summary>
    /// Chain of responsibility with no output and four parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    public interface IVoidChain<in T1, in T2, in T3, in T4>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        /// <param name="t4">Fourth input parameter of a chain.</param>
        void Execute(T1 t1, T2 t2, T3 t3, T4 t4);
    }

    /// <summary>
    /// Chain of responsibility with no output and five parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of chain fifth input parameter.</typeparam>
    public interface IVoidChain<in T1, in T2, in T3, in T4, in T5>
    {
        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        /// <param name="t4">Fourth input parameter of a chain.</param>
        /// <param name="t5">Fifth input parameter of a chain.</param>
        void Execute(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
    }
}
