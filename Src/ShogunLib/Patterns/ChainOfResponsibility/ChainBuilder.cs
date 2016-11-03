// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    #region Void

    /// <summary>
    /// 
    /// </summary>
    public sealed class VoidChainBuilder : IVoidChainBuilder
    {
        private readonly IList<IVoidLink> _links;

        /// <summary>
        /// 
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder Add(Func<bool> cando, Action voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IVoidChainBuilder Add(IVoidLink link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder Add(ICan cando, IVoidDo voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IVoidChain Build()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    public sealed class VoidChainBuilder<T1> : IVoidChainBuilder<T1>
    {
        private readonly IList<IVoidLink<T1>> _links;

        /// <summary>
        /// 
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1> Add(Func<T1, bool> cando, Action<T1> voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1> Add(IVoidLink<T1> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1> Add(ICan<T1> cando, IVoidDo<T1> voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IVoidChain<T1> Build()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public sealed class VoidChainBuilder<T1, T2> : IVoidChainBuilder<T1, T2>
    {
        private readonly IList<IVoidLink<T1, T2>> _links;

        /// <summary>
        /// 
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2> Add(Func<T1, T2, bool> cando, Action<T1, T2> voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2> Add(IVoidLink<T1, T2> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2> Add(ICan<T1, T2> cando, IVoidDo<T1, T2> voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IVoidChain<T1, T2> Build()
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
    public sealed class VoidChainBuilder<T1, T2, T3> : IVoidChainBuilder<T1, T2, T3>
    {
        private readonly IList<IVoidLink<T1, T2, T3>> _links;

        /// <summary>
        /// 
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2, T3>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2, T3> Add(Func<T1, T2, T3, bool> cando, Action<T1, T2, T3> voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2, T3> Add(IVoidLink<T1, T2, T3> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2, T3> Add(ICan<T1, T2, T3> cando, IVoidDo<T1, T2, T3> voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IVoidChain<T1, T2, T3> Build()
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
    public sealed class VoidChainBuilder<T1, T2, T3, T4> : IVoidChainBuilder<T1, T2, T3, T4>
    {
        private readonly IList<IVoidLink<T1, T2, T3, T4>> _links;

        /// <summary>
        /// 
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2, T3, T4>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2, T3, T4> Add(Func<T1, T2, T3, T4, bool> cando, Action<T1, T2, T3, T4> voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2, T3, T4> Add(IVoidLink<T1, T2, T3, T4> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2, T3, T4> Add(ICan<T1, T2, T3, T4> cando, IVoidDo<T1, T2, T3, T4> voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IVoidChain<T1, T2, T3, T4> Build()
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
    public sealed class VoidChainBuilder<T1, T2, T3, T4, T5> : IVoidChainBuilder<T1, T2, T3, T4, T5>
    {
        private readonly IList<IVoidLink<T1, T2, T3, T4, T5>> _links;

        /// <summary>
        /// 
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2, T3, T4, T5>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2, T3, T4, T5> Add(Func<T1, T2, T3, T4, T5, bool> cando, Action<T1, T2, T3, T4, T5> voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2, T3, T4, T5> Add(IVoidLink<T1, T2, T3, T4, T5> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="voidDo"></param>
        /// <returns></returns>
        public IVoidChainBuilder<T1, T2, T3, T4, T5> Add(ICan<T1, T2, T3, T4, T5> cando, IVoidDo<T1, T2, T3, T4, T5> voidDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IVoidChain<T1, T2, T3, T4, T5> Build()
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
    public sealed class ResultChainBuilder<TResult> : IResultChainBuilder<TResult>
    {
        private readonly IList<IResultLink<TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<TResult>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<TResult> Add(Func<bool> cando, Func<TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IResultChainBuilder<TResult> Add(IResultLink<TResult> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<TResult> Add(ICan cando, IResultDo<TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IResultChain<TResult> Build()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public sealed class ResultChainBuilder<T1, TResult> : IResultChainBuilder<T1, TResult>
    {
        private readonly IList<IResultLink<T1, TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, TResult>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, TResult> Add(Func<T1, bool> cando, Func<T1, TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, TResult> Add(IResultLink<T1, TResult> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, TResult> Add(ICan<T1> cando, IResultDo<T1, TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IResultChain<T1, TResult> Build()
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
    public sealed class ResultChainBuilder<T1, T2, TResult> : IResultChainBuilder<T1, T2, TResult>
    {
        private readonly IList<IResultLink<T1, T2, TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, TResult>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, TResult> Add(Func<T1, T2, bool> cando, Func<T1, T2, TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, TResult> Add(IResultLink<T1, T2, TResult> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, TResult> Add(ICan<T1, T2> cando, IResultDo<T1, T2, TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IResultChain<T1, T2, TResult> Build()
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
    public sealed class ResultChainBuilder<T1, T2, T3, TResult> : IResultChainBuilder<T1, T2, T3, TResult>
    {
        private readonly IList<IResultLink<T1, T2, T3, TResult>> _links;
        
        /// <summary>
        /// 
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, T3, TResult>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, T3, TResult> Add(Func<T1, T2, T3, bool> cando, Func<T1, T2, T3, TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, T3, TResult> Add(IResultLink<T1, T2, T3, TResult> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, T3, TResult> Add(ICan<T1, T2, T3> cando, IResultDo<T1, T2, T3, TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IResultChain<T1, T2, T3, TResult> Build()
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
    public sealed class ResultChainBuilder<T1, T2, T3, T4, TResult> : IResultChainBuilder<T1, T2, T3, T4, TResult>
    {
        private readonly IList<IResultLink<T1, T2, T3, T4, TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, T3, T4, TResult>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, T3, T4, TResult> Add(Func<T1, T2, T3, T4, bool> cando, Func<T1, T2, T3, T4, TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, T3, T4, TResult> Add(IResultLink<T1, T2, T3, T4, TResult> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, T3, T4, TResult> Add(ICan<T1, T2, T3, T4> cando, IResultDo<T1, T2, T3, T4, TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IResultChain<T1, T2, T3, T4, TResult> Build()
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
    public sealed class ResultChainBuilder<T1, T2, T3, T4, T5, TResult> : IResultChainBuilder<T1, T2, T3, T4, T5, TResult>
    {
        private readonly IList<IResultLink<T1, T2, T3, T4, T5, TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, T3, T4, T5, TResult>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(Func<T1, T2, T3, T4, T5, bool> cando, Func<T1, T2, T3, T4, T5, TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(IResultLink<T1, T2, T3, T4, T5, TResult> link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        /// <param name="resultDo"></param>
        /// <returns></returns>
        public IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(ICan<T1, T2, T3, T4, T5> cando, IResultDo<T1, T2, T3, T4, T5, TResult> resultDo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IResultChain<T1, T2, T3, T4, T5, TResult> Build()
        {
            throw new NotImplementedException();
        }
    }

    #endregion
}
