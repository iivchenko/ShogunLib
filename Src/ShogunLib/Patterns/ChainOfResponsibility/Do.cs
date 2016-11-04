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
    /// Defines link action with void output and no input parameters.
    /// </summary>
    public sealed class VoidDo : IVoidDo
    {
        private readonly Action _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidDo"/> type.
        /// </summary>
        /// <param name="voidDo">Link action.</param>
        public VoidDo(Action voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        public void Do()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines link action with void output and one input parameter.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    public sealed class VoidDo<T1> : IVoidDo<T1>
    {
        private readonly Action<T1> _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidDo{T1}"/> type.
        /// </summary>
        /// <param name="voidDo">Link action.</param>
        public VoidDo(Action<T1> voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        public void Do(T1 t1)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines link action with void output and two input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    public sealed class VoidDo<T1, T2> : IVoidDo<T1, T2>
    {
        private readonly Action<T1, T2> _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidDo{T1, T2}"/> type.
        /// </summary>
        /// <param name="voidDo">Link action.</param>
        public VoidDo(Action<T1, T2> voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        public void Do(T1 t1, T2 t2)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines link action with void output and three input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    public sealed class VoidDo<T1, T2, T3> : IVoidDo<T1, T2, T3>
    {
        private readonly Action<T1, T2, T3> _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidDo{T1, T2, T3}"/> type.
        /// </summary>
        /// <param name="voidDo">Link action.</param>
        public VoidDo(Action<T1, T2, T3> voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        public void Do(T1 t1, T2 t2, T3 t3)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines link action with void output and four input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    public sealed class VoidDo<T1, T2, T3, T4> : IVoidDo<T1, T2, T3, T4>
    {
        private readonly Action<T1, T2, T3, T4> _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidDo{T1, T2, T3, T4}"/> type.
        /// </summary>
        /// <param name="voidDo">Link action.</param>
        public VoidDo(Action<T1, T2, T3, T4> voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        public void Do(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Defines link action with void output and five input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of link fifth input parameter.</typeparam>
    public sealed class VoidDo<T1, T2, T3, T4, T5> : IVoidDo<T1, T2, T3, T4, T5>
    {
        private readonly Action<T1, T2, T3, T4, T5> _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidDo{T1, T2, T3, T4, T5}"/> type.
        /// </summary>
        /// <param name="voidDo">Link action.</param>
        public VoidDo(Action<T1, T2, T3, T4, T5> voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <param name="t5">Fifth input parameter of a link.</param>
        public void Do(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region Result

    /// <summary>
    /// Defines link action with output and no input parameters.
    /// </summary>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public sealed class ResultDo<TResult> : IResultDo<TResult>
    {
        private readonly Func<TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultDo{TResult}"/> type.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<TResult> resultDo)
        {
            _resultDo = resultDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <returns>Result of a link action.</returns>
        public TResult Do()
        {
            throw new NotImplementedException();
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
        /// Initializes a new instance of the <see cref="ResultDo{T1, TResult}"/> type.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<T1, TResult> resultDo)
        {
            _resultDo = resultDo;
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <returns>Result of a link action.</returns>
        public TResult Do(T1 t1)
        {
            throw new NotImplementedException();
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
        /// Initializes a new instance of the <see cref="ResultDo{T1, T2, TResult}"/> type.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<T1, T2, TResult> resultDo)
        {
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
            throw new NotImplementedException();
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
        /// Initializes a new instance of the <see cref="ResultDo{T1, T2, T3, TResult}"/> type.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<T1, T2, T3, TResult> resultDo)
        {
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
            throw new NotImplementedException();
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
    public sealed class ResultDo<T1, T2, T3, T4,  TResult> : IResultDo<T1, T2, T3, T4, TResult>
    {
        private readonly Func<T1, T2, T3, T4, TResult> _resultDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultDo{T1, T2, T3, T4, TResult}"/> type.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<T1, T2, T3, T4, TResult> resultDo)
        {
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
            throw new NotImplementedException();
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
        /// Initializes a new instance of the <see cref="ResultDo{T1, T2, T3, T4, T5, TResult}"/> type.
        /// </summary>
        /// <param name="resultDo">Link action.</param>
        public ResultDo(Func<T1, T2, T3, T4, T5, TResult> resultDo)
        {
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
            throw new NotImplementedException();
        }
    }

    #endregion
}
