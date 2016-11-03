// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// 
    /// </summary>
    public static class Chain
    {
        #region Void

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static IVoidChainBuilder CreateVoid()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <returns></returns>
        public static IVoidChainBuilder<T1> CreateVoid<T1>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <returns></returns>
        public static IVoidChainBuilder<T1, T2> CreateVoid<T1, T2>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <returns></returns>
        public static IVoidChainBuilder<T1, T2, T3> CreateVoid<T1, T2, T3>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <returns></returns>
        public static IVoidChainBuilder<T1, T2, T3, T4> CreateVoid<T1, T2, T3, T4>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <returns></returns>
        public static IVoidChainBuilder<T1, T2, T3, T4, T5> CreateVoid<T1, T2, T3, T4, T5>()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Result

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static IResultChainBuilder<TResult> CreateResult<TResult>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static IResultChainBuilder<T1, TResult> CreateResult<T1, TResult>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static IResultChainBuilder<T1, T2, TResult> CreateResult<T1, T2, TResult>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static IResultChainBuilder<T1, T2, T3, TResult> CreateResult<T1, T2, T3, TResult>()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static IResultChainBuilder<T1, T2, T3, T4, TResult> CreateResult<T1, T2, T3, T4, TResult>()
        {
            throw new NotImplementedException();
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
        /// <returns></returns>
        public static IResultChainBuilder<T1, T2, T3, T4, T5, TResult> CreateResult<T1, T2, T3, T4, T5, TResult>()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    #region Void 

    /// <summary>
    /// 
    /// </summary>
    public class VoidChain : IVoidChain
    {
        private readonly IEnumerable<IVoidLink> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public VoidChain(IEnumerable<IVoidLink> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    public class VoidChain<T1> : IVoidChain<T1>
    {
        private readonly IEnumerable<IVoidLink<T1>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public VoidChain(IEnumerable<IVoidLink<T1>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        public void Execute(T1 t1)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public class VoidChain<T1, T2> : IVoidChain<T1, T2>
    {
        private readonly IEnumerable<IVoidLink<T1, T2>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public VoidChain(IEnumerable<IVoidLink<T1, T2>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        public void Execute(T1 t1, T2 t2)
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
    public class VoidChain<T1, T2, T3> : IVoidChain<T1, T2, T3>
    {
        private readonly IEnumerable<IVoidLink<T1, T2, T3>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public VoidChain(IEnumerable<IVoidLink<T1, T2, T3>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        public void Execute(T1 t1, T2 t2, T3 t3)
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
    public class VoidChain<T1, T2, T3, T4> : IVoidChain<T1, T2, T3, T4>
    {
        private readonly IEnumerable<IVoidLink<T1, T2, T3, T4>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public VoidChain(IEnumerable<IVoidLink<T1, T2, T3, T4>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        public void Execute(T1 t1, T2 t2, T3 t3, T4 t4)
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
    public class VoidChain<T1, T2, T3, T4, T5> : IVoidChain<T1, T2, T3, T4, T5>
    {
        private readonly IEnumerable<IVoidLink<T1, T2, T3, T4, T5>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public VoidChain(IEnumerable<IVoidLink<T1, T2, T3, T4, T5>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <param name="t5"></param>
        public void Execute(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
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
    public class ResultChain<TResult> : IResultChain<TResult>
    {
        private readonly IEnumerable<IResultLink<TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public ResultChain(IEnumerable<IResultLink<TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public TResult Execute()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class ResultChain<T1, TResult> : IResultChain<T1, TResult>
    {
        private readonly IEnumerable<IResultLink<T1, TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public ResultChain(IEnumerable<IResultLink<T1, TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <returns></returns>
        public TResult Execute(T1 t1)
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
    public class ResultChain<T1, T2, TResult> : IResultChain<T1, T2, TResult>
    {
        private readonly IEnumerable<IResultLink<T1, T2, TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public ResultChain(IEnumerable<IResultLink<T1, T2, TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public TResult Execute(T1 t1, T2 t2)
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
    public class ResultChain<T1, T2, T3, TResult> : IResultChain<T1, T2, T3, TResult>
    {
        private readonly IEnumerable<IResultLink<T1, T2, T3, TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public ResultChain(IEnumerable<IResultLink<T1, T2, T3, TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <returns></returns>
        public TResult Execute(T1 t1, T2 t2, T3 t3)
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
    public class ResultChain<T1, T2, T3, T4, TResult> : IResultChain<T1, T2, T3, T4, TResult>
    {
        private readonly IEnumerable<IResultLink<T1, T2, T3, T4, TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public ResultChain(IEnumerable<IResultLink<T1, T2, T3, T4, TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <returns></returns>
        public TResult Execute(T1 t1, T2 t2, T3 t3, T4 t4)
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
    public class ResultChain<T1, T2, T3, T4, T5, TResult> : IResultChain<T1, T2, T3, T4, T5, TResult>
    {
        private readonly IEnumerable<IResultLink<T1, T2, T3, T4, T5, TResult>> _links;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="links"></param>
        public ResultChain(IEnumerable<IResultLink<T1, T2, T3, T4, T5, TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
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
        public TResult Execute(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            throw new NotImplementedException();
        }
    }

    #endregion
}
