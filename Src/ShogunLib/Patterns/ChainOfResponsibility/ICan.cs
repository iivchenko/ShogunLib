// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Defines predicate (no input parameters) that determines wherther a link can handle input request.
    /// </summary>
    public interface ICan
    {
        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <returns>true - link can handle; false - link can't handle</returns>
        bool Cando();
    }

    /// <summary>
    /// Defines predicate (one input parameter) that determines wherther a link can handle input request.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    public interface ICan<in T1>
    {
        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        bool Cando(T1 t1);
    }

    /// <summary>
    /// Defines predicate (two input parameter) that determines wherther a link can handle input request.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    public interface ICan<in T1, in T2>
    {
        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        bool Cando(T1 t1, T2 t2);
    }

    /// <summary>
    /// Defines predicate (three input parameter) that determines wherther a link can handle input request.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    public interface ICan<in T1, in T2, in T3>
    {
        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        bool Cando(T1 t1, T2 t2, T3 t3);
    }

    /// <summary>
    /// Defines predicate (four input parameter) that determines wherther a link can handle input request.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    public interface ICan<in T1, in T2, in T3, in T4>
    {
        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        bool Cando(T1 t1, T2 t2, T3 t3, T4 t4);
    }

    /// <summary>
    /// Defines predicate (five input parameter) that determines wherther a link can handle input request.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of link fifth input parameter.</typeparam>
    public interface ICan<in T1, in T2, in T3, in T4, in T5>
    {
        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <param name="t5">Fifth input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        bool Cando(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
    }
}
