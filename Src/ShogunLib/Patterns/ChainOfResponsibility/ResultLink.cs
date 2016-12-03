// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Chain link with output and no input parameters.
    /// </summary>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultLink<TResult> : IResultLink<TResult>
    {
        private readonly ICan _cando;
        private readonly IResultDo<TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(Func<bool> cando, Func<TResult> resultDo)
            : this(new Can(cando), new ResultDo<TResult>(resultDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(ICan cando, IResultDo<TResult> resultDo)
        {
            cando.ValidateNull(nameof(cando));
            resultDo.ValidateNull(nameof(resultDo));

            _cando = cando;
            _resultDo = resultDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando()
        {
            return _cando.Cando();
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <returns>Result of a link action.</returns>
        public TResult Do()
        {
            return _resultDo.Do();
        }
    }

    /// <summary>
    /// Chain link with output and one input parameter.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultLink<T1, TResult> : IResultLink<T1, TResult>
    {
        private readonly ICan<T1> _cando;
        private readonly IResultDo<T1, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{T1, TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(Func<T1, bool> cando, Func<T1, TResult> resultDo)
            : this(new Can<T1>(cando), new ResultDo<T1, TResult>(resultDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{T1, TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(ICan<T1> cando, IResultDo<T1, TResult> resultDo)
        {
            cando.ValidateNull(nameof(cando));
            resultDo.ValidateNull(nameof(resultDo));

            _cando = cando;
            _resultDo = resultDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1)
        {
            return _cando.Cando(t1);
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <returns>Result of a link action.</returns>
        public TResult Do(T1 t1)
        {
            return _resultDo.Do(t1);
        }
    }

    /// <summary>
    /// Chain link with output and two input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultLink<T1, T2, TResult> : IResultLink<T1, T2, TResult>
    {
        private readonly ICan<T1, T2> _cando;
        private readonly IResultDo<T1, T2, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{T1, T2, TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(Func<T1, T2, bool> cando, Func<T1, T2, TResult> resultDo)
            : this(new Can<T1, T2>(cando), new ResultDo<T1, T2, TResult>(resultDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{T1, T2, TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(ICan<T1, T2> cando, IResultDo<T1, T2, TResult> resultDo)
        {
            cando.ValidateNull(nameof(cando));
            resultDo.ValidateNull(nameof(resultDo));

            _cando = cando;
            _resultDo = resultDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2)
        {
            return _cando.Cando(t1, t2);
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <returns>Result of a link action.</returns>
        public TResult Do(T1 t1, T2 t2)
        {
            return _resultDo.Do(t1, t2);
        }
    }

    /// <summary>
    /// Chain link with output and three input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultLink<T1, T2, T3, TResult> : IResultLink<T1, T2, T3, TResult>
    {
        private readonly ICan<T1, T2, T3> _cando;
        private readonly IResultDo<T1, T2, T3, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{T1, T2, T3, TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(Func<T1, T2, T3, bool> cando, Func<T1, T2, T3, TResult> resultDo)
            : this(new Can<T1, T2, T3>(cando), new ResultDo<T1, T2, T3, TResult>(resultDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{T1, T2, T3, TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(ICan<T1, T2, T3> cando, IResultDo<T1, T2, T3, TResult> resultDo)
        {
            cando.ValidateNull(nameof(cando));
            resultDo.ValidateNull(nameof(resultDo));

            _cando = cando;
            _resultDo = resultDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2, T3 t3)
        {
            return _cando.Cando(t1, t2, t3);
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
            return _resultDo.Do(t1, t2, t3);
        }
    }

    /// <summary>
    /// Chain link with output and four input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultLink<T1, T2, T3, T4, TResult> : IResultLink<T1, T2, T3, T4, TResult>
    {
        private readonly ICan<T1, T2, T3, T4> _cando;
        private readonly IResultDo<T1, T2, T3, T4, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{T1, T2, T3, T4, TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(Func<T1, T2, T3, T4, bool> cando, Func<T1, T2, T3, T4, TResult> resultDo)
            : this(new Can<T1, T2, T3, T4>(cando), new ResultDo<T1, T2, T3, T4, TResult>(resultDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{T1, T2, T3, T4, TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(ICan<T1, T2, T3, T4> cando, IResultDo<T1, T2, T3, T4, TResult> resultDo)
        {
            cando.ValidateNull(nameof(cando));
            resultDo.ValidateNull(nameof(resultDo));

            _cando = cando;
            _resultDo = resultDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return _cando.Cando(t1, t2, t3, t4);
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
            return _resultDo.Do(t1, t2, t3, t4);
        }
    }

    /// <summary>
    /// Chain link with output and five input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of link fifth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultLink<T1, T2, T3, T4, T5, TResult> : IResultLink<T1, T2, T3, T4, T5, TResult>
    {
        private readonly ICan<T1, T2, T3, T4, T5> _cando;
        private readonly IResultDo<T1, T2, T3, T4, T5, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{T1, T2, T3, T4, T5, TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(Func<T1, T2, T3, T4, T5, bool> cando, Func<T1, T2, T3, T4, T5, TResult> resultDo)
            : this(new Can<T1, T2, T3, T4, T5>(cando), new ResultDo<T1, T2, T3, T4, T5, TResult>(resultDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultLink{T1, T2, T3, T4, T5, TResult}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        public ResultLink(ICan<T1, T2, T3, T4, T5> cando, IResultDo<T1, T2, T3, T4, T5, TResult> resultDo)
        {
            cando.ValidateNull(nameof(cando));
            resultDo.ValidateNull(nameof(resultDo));

            _cando = cando;
            _resultDo = resultDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <param name="t5">Fifth input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return _cando.Cando(t1, t2, t3, t4, t5);
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
            return _resultDo.Do(t1, t2, t3, t4, t5);
        }
    }
}
