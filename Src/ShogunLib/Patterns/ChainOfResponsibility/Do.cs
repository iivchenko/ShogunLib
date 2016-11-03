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
    public sealed class VoidDo : IVoidDo
    {
        private readonly Action _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="voidDo"></param>
        public VoidDo(Action voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Do()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    public sealed class VoidDo<T1> : IVoidDo<T1>
    {
        private readonly Action<T1> _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="voidDo"></param>
        public VoidDo(Action<T1> voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        public void Do(T1 t1)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public sealed class VoidDo<T1, T2> : IVoidDo<T1, T2>
    {
        private readonly Action<T1, T2> _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="voidDo"></param>
        public VoidDo(Action<T1, T2> voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        public void Do(T1 t1, T2 t2)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    public sealed class VoidDo<T1, T2, T3> : IVoidDo<T1, T2, T3>
    {
        private readonly Action<T1, T2, T3> _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="voidDo"></param>
        public VoidDo(Action<T1, T2, T3> voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        public void Do(T1 t1, T2 t2, T3 t3)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    public sealed class VoidDo<T1, T2, T3, T4> : IVoidDo<T1, T2, T3, T4>
    {
        private readonly Action<T1, T2, T3, T4> _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="voidDo"></param>
        public VoidDo(Action<T1, T2, T3, T4> voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        public void Do(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    public sealed class VoidDo<T1, T2, T3, T4, T5> : IVoidDo<T1, T2, T3, T4, T5>
    {
        private readonly Action<T1, T2, T3, T4, T5> _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="voidDo"></param>
        public VoidDo(Action<T1, T2, T3, T4, T5> voidDo)
        {
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <param name="t5"></param>
        public void Do(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region Result

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public sealed class ResultDo<TResult> : IResultDo<TResult>
    {
        private readonly Func<TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultDo"></param>
        public ResultDo(Func<TResult> resultDo)
        {
            _resultDo = resultDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public TResult Do()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public sealed class ResultDo<T1, TResult> : IResultDo<T1, TResult>
    {
        private readonly Func<T1, TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultDo"></param>
        public ResultDo(Func<T1, TResult> resultDo)
        {
            _resultDo = resultDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <returns></returns>
        public TResult Do(T1 t1)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public sealed class ResultDo<T1, T2, TResult> : IResultDo<T1, T2, TResult>
    {
        private readonly Func<T1, T2, TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultDo"></param>
        public ResultDo(Func<T1, T2, TResult> resultDo)
        {
            _resultDo = resultDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public TResult Do(T1 t1, T2 t2)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public sealed class ResultDo<T1, T2, T3, TResult> : IResultDo<T1, T2, T3, TResult>
    {
        private readonly Func<T1, T2, T3, TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultDo"></param>
        public ResultDo(Func<T1, T2, T3, TResult> resultDo)
        {
            _resultDo = resultDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <returns></returns>
        public TResult Do(T1 t1, T2 t2, T3 t3)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public sealed class ResultDo<T1, T2, T3, T4,  TResult> : IResultDo<T1, T2, T3, T4, TResult>
    {
        private readonly Func<T1, T2, T3, T4, TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultDo"></param>
        public ResultDo(Func<T1, T2, T3, T4, TResult> resultDo)
        {
            _resultDo = resultDo;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <returns></returns>
        public TResult Do(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            throw new NotImplementedException();
        }
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
    public sealed class ResultDo<T1, T2, T3, T4, T5, TResult> : IResultDo<T1, T2, T3, T4, T5, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultDo"></param>
        public ResultDo(Func<T1, T2, T3, T4, T5, TResult> resultDo)
        {
            _resultDo = resultDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <param name="t5"></param>
        /// <returns></returns>
        public TResult Do(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            throw new NotImplementedException();
        }
    }

    #endregion
}
