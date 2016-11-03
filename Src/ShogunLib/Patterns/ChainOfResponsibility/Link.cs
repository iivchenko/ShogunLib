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
    public sealed class VoidLink : IVoidLink
    {
        private readonly ICan _cando;
        private readonly IVoidDo _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(Func<bool> cando, Action voidDo)
            : this(new Can(cando), new VoidDo(voidDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(ICan cando, IVoidDo voidDo)
        {
            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Cando()
        {
            throw new NotImplementedException();
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
    public sealed class VoidLink<T1> : IVoidLink<T1>
    {
        private readonly ICan<T1> _cando;
        private readonly IVoidDo<T1> _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(Func<T1, bool> cando, Action<T1> voidDo)
            : this(new Can<T1>(cando), new VoidDo<T1>(voidDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(ICan<T1> cando, IVoidDo<T1> voidDo)
        {
            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <returns></returns>
        public bool Cando(T1 t1)
        {
            throw new NotImplementedException();
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
    public sealed class VoidLink<T1, T2> : IVoidLink<T1, T2>
    {
        private readonly ICan<T1, T2> _cando;
        private readonly IVoidDo<T1, T2> _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(Func<T1, T2, bool> cando, Action<T1, T2> voidDo)
            : this(new Can<T1, T2>(cando), new VoidDo<T1, T2>(voidDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(ICan<T1, T2> cando, IVoidDo<T1, T2> voidDo)
        {
            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public bool Cando(T1 t1, T2 t2)
        {
            throw new NotImplementedException();
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
    public sealed class VoidLink<T1, T2, T3> : IVoidLink<T1, T2, T3>
    {
        private readonly ICan<T1, T2, T3> _cando;
        private readonly IVoidDo<T1, T2, T3> _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(Func<T1, T2, T3, bool> cando, Action<T1, T2, T3> voidDo)
            : this(new Can<T1, T2, T3>(cando), new VoidDo<T1, T2, T3>(voidDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(ICan<T1, T2, T3> cando, IVoidDo<T1, T2, T3> voidDo)
        {
            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <returns></returns>
        public bool Cando(T1 t1, T2 t2, T3 t3)
        {
            throw new NotImplementedException();
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
    public sealed class VoidLink<T1, T2, T3, T4> : IVoidLink<T1, T2, T3, T4>
    {
        private readonly ICan<T1, T2, T3, T4> _cando;
        private readonly IVoidDo<T1, T2, T3, T4> _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(Func<T1, T2, T3, T4, bool> cando, Action<T1, T2, T3, T4> voidDo)
            : this(new Can<T1, T2, T3, T4>(cando), new VoidDo<T1, T2, T3, T4>(voidDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(ICan<T1, T2, T3, T4> cando, IVoidDo<T1, T2, T3, T4> voidDo)
        {
            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <returns></returns>
        public bool Cando(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            throw new NotImplementedException();
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
    public sealed class VoidLink<T1, T2, T3, T4, T5> : IVoidLink<T1, T2, T3, T4, T5>
    {
        private readonly ICan<T1, T2, T3, T4, T5> _cando;
        private readonly IVoidDo<T1, T2, T3, T4, T5> _voidDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(Func<T1, T2, T3, T4, T5, bool> cando, Action<T1, T2, T3, T4, T5> voidDo)
            : this(new Can<T1, T2, T3, T4, T5>(cando), new VoidDo<T1, T2, T3, T4, T5>(voidDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        public VoidLink(ICan<T1, T2, T3, T4, T5> cando, IVoidDo<T1, T2, T3, T4, T5> voidDo)
        {
            _cando = cando;
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
        /// <returns></returns>
        public bool Cando(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            throw new NotImplementedException();
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
    public sealed class ResultLink<TResult> : IResultLink<TResult>
    {
        private readonly ICan _cando;
        private readonly IResultDo<TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(Func<bool> cando, Func<TResult> resultDo)
            : this(new Can(cando), new ResultDo<TResult> (resultDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(ICan cando, IResultDo<TResult> resultDo)
        {
            _cando = cando;
            _resultDo = resultDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Cando()
        {
            throw new NotImplementedException();
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
    public sealed class ResultLink<T1, TResult> : IResultLink<T1, TResult>
    {
        private readonly ICan<T1> _cando;
        private readonly IResultDo<T1, TResult> _resultDo;

        /// <summary>
        /// /
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(Func<T1, bool> cando, Func<T1, TResult> resultDo)
            : this(new Can<T1>(cando), new ResultDo<T1, TResult>(resultDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(ICan<T1> cando, IResultDo<T1, TResult> resultDo)
        {
            _cando = cando;
            _resultDo = resultDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <returns></returns>
        public bool Cando(T1 t1)
        {
            throw new NotImplementedException();
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
    public sealed class ResultLink<T1, T2, TResult> : IResultLink<T1, T2, TResult>
    {
        private readonly ICan<T1, T2> _cando;
        private readonly IResultDo<T1, T2, TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(Func<T1, T2, bool> cando, Func<T1, T2, TResult> resultDo)
            : this(new Can<T1, T2>(cando), new ResultDo<T1, T2, TResult>(resultDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(ICan<T1, T2> cando, IResultDo<T1, T2, TResult> resultDo)
        {
            _cando = cando;
            _resultDo = resultDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public bool Cando(T1 t1, T2 t2)
        {
            throw new NotImplementedException();
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
    public sealed class ResultLink<T1, T2, T3, TResult> : IResultLink<T1, T2, T3, TResult>
    {
        private readonly ICan<T1, T2, T3> _cando;
        private readonly IResultDo<T1, T2, T3, TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(Func<T1, T2, T3, bool> cando, Func<T1, T2, T3, TResult> resultDo)
            : this(new Can<T1, T2, T3>(cando), new ResultDo<T1, T2, T3, TResult>(resultDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(ICan<T1, T2, T3> cando, IResultDo<T1, T2, T3, TResult> resultDo)
        {
            _cando = cando;
            _resultDo = resultDo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <returns></returns>
        public bool Cando(T1 t1, T2 t2, T3 t3)
        {
            throw new NotImplementedException();
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
    public sealed class ResultLink<T1, T2, T3, T4, TResult> : IResultLink<T1, T2, T3, T4, TResult>
    {
        private readonly ICan<T1, T2, T3, T4> _cando;
        private readonly IResultDo<T1, T2, T3, T4, TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(Func<T1, T2, T3, T4, bool> cando, Func<T1, T2, T3, T4, TResult> resultDo)
            : this(new Can<T1, T2, T3, T4>(cando), new ResultDo<T1, T2, T3, T4, TResult>(resultDo))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(ICan<T1, T2, T3, T4> cando, IResultDo<T1, T2, T3, T4, TResult> resultDo)
        {
            _cando = cando;
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
        public bool Cando(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            throw new NotImplementedException();
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
    public sealed class ResultLink<T1, T2, T3, T4, T5, TResult> : IResultLink<T1, T2, T3, T4, T5, TResult>
    {
        private readonly ICan<T1, T2, T3, T4, T5> _cando;
        private readonly IResultDo<T1, T2, T3, T4, T5, TResult> _resultDo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(Func<T1, T2, T3, T4, T5, bool> cando, Func<T1, T2, T3, T4, T5, TResult> resultDo)
            : this(new Can<T1, T2, T3, T4, T5>(cando), new ResultDo<T1, T2, T3, T4, T5, TResult>(resultDo))
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        public ResultLink(ICan<T1, T2, T3, T4, T5> cando, IResultDo<T1, T2, T3, T4, T5, TResult> resultDo)
        {
            _cando = cando;
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
        public bool Cando(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            throw new NotImplementedException();
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
