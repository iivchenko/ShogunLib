// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>
using System;

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Defines predicate (no input parameters) that determines wherther a link can handle input request.
    /// </summary>
    public sealed class Can : ICan
    {
        private readonly Func<bool> _cando;

        /// <summary>
        /// Initializes a new instance of the <see cref="Can"/> type.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        public Can(Func<bool> cando)
        {
            _cando = cando;
        }

        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines predicate (one input parameter) that determines wherther a link can handle input request.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    public sealed class Can<T1> : ICan<T1>
    {
        private readonly Func<T1, bool> _cando;

        /// <summary>
        /// Initializes a new instance of the <see cref="Can{T1}"/> type.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        public Can(Func<T1, bool> cando)
        {
            _cando = cando;
        }

        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines predicate (two input parameter) that determines wherther a link can handle input request.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    public sealed class Can<T1, T2> : ICan<T1, T2>
    {
        private readonly Func<T1, T2, bool> _cando;

        /// <summary>
        /// Initializes a new instance of the <see cref="Can{T1, T2}"/> type.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        public Can(Func<T1, T2, bool> cando)
        {
            _cando = cando;
        }

        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines predicate (three input parameter) that determines wherther a link can handle input request.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    public sealed class Can<T1, T2, T3> : ICan<T1, T2, T3>
    {
        private readonly Func<T1, T2, T3, bool> _cando;

        /// <summary>
        /// Initializes a new instance of the <see cref="Can{T1, T2, T3}"/> type.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        public Can(Func<T1, T2, T3, bool> cando)
        {
            _cando = cando;
        }

        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2, T3 t3)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines predicate (four input parameter) that determines wherther a link can handle input request.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    public sealed class Can<T1, T2, T3, T4> : ICan<T1, T2, T3, T4>
    {
        private readonly Func<T1, T2, T3, T4, bool> _cando;

        /// <summary>
        /// Initializes a new instance of the <see cref="Can{T1, T2, T3, T4}"/> type.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        public Can(Func<T1, T2, T3, T4, bool> cando)
        {
            _cando = cando;
        }

        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines predicate (five input parameter) that determines wherther a link can handle input request.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of link fifth input parameter.</typeparam>
    public sealed class Can<T1, T2, T3, T4, T5> : ICan<T1, T2, T3, T4, T5>
    {
        private readonly Func<T1, T2, T3, T4, T5, bool> _cando;

        /// <summary>
        /// Initializes a new instance of the <see cref="Can{T1, T2, T3, T4, T5}"/> type.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        public Can(Func<T1, T2, T3, T4, T5, bool> cando)
        {
            _cando = cando;
        }

        /// <summary>
        /// Determines wherther a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <param name="t5">Fifth input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            throw new NotImplementedException();
        }
    }
}
