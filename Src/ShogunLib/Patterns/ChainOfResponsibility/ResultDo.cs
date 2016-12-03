// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Defines link action with output and no input parameters.
    /// </summary>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultDo<TResult> : IResultDo<TResult>
    {
        private readonly Func<TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultDo{TResult}"/> class.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<TResult> resultDo)
        {
            resultDo.ValidateNull(nameof(resultDo));

            _resultDo = resultDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <returns>Result of a link action.</returns>
        public TResult Do()
        {
            return _resultDo();
        }
    }

    /// <summary>
    /// Defines link action with output and one input parameter.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultDo<T1, TResult> : IResultDo<T1, TResult>
    {
        private readonly Func<T1, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultDo{T1, TResult}"/> class.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<T1, TResult> resultDo)
        {
            resultDo.ValidateNull(nameof(resultDo));

            _resultDo = resultDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <returns>Result of a link action.</returns>
        public TResult Do(T1 t1)
        {
            return _resultDo(t1);
        }
    }

    /// <summary>
    /// Defines link action with output and two input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultDo<T1, T2, TResult> : IResultDo<T1, T2, TResult>
    {
        private readonly Func<T1, T2, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultDo{T1, T2, TResult}"/> class.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<T1, T2, TResult> resultDo)
        {
            resultDo.ValidateNull(nameof(resultDo));

            _resultDo = resultDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <returns>Result of a link action.</returns>
        public TResult Do(T1 t1, T2 t2)
        {
            return _resultDo(t1, t2);
        }
    }

    /// <summary>
    /// Defines link action with output and three input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultDo<T1, T2, T3, TResult> : IResultDo<T1, T2, T3, TResult>
    {
        private readonly Func<T1, T2, T3, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultDo{T1, T2, T3, TResult}"/> class.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<T1, T2, T3, TResult> resultDo)
        {
            resultDo.ValidateNull(nameof(resultDo));

            _resultDo = resultDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <returns>Result of a link action.</returns>
        public TResult Do(T1 t1, T2 t2, T3 t3)
        {
            return _resultDo(t1, t2, t3);
        }
    }

    /// <summary>
    /// Defines link action with output and four input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fifth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultDo<T1, T2, T3, T4, TResult> : IResultDo<T1, T2, T3, T4, TResult>
    {
        private readonly Func<T1, T2, T3, T4, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultDo{T1, T2, T3, T4, TResult}"/> class.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<T1, T2, T3, T4, TResult> resultDo)
        {
            resultDo.ValidateNull(nameof(resultDo));

            _resultDo = resultDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <returns>Result of a link action.</returns>
        public TResult Do(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return _resultDo(t1, t2, t3, t4);
        }
    }

    /// <summary>
    /// Defines link action with output and five input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of link fifth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultDo<T1, T2, T3, T4, T5, TResult> : IResultDo<T1, T2, T3, T4, T5, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultDo{T1, T2, T3, T4, T5, TResult}"/> class.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<T1, T2, T3, T4, T5, TResult> resultDo)
        {
            resultDo.ValidateNull(nameof(resultDo));

            _resultDo = resultDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <param name="t5">Fifth input parameter of a link.</param>
        /// <returns>Result of a link action.</returns>
        public TResult Do(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return _resultDo(t1, t2, t3, t4, t5);
        }
    }
}
