// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System.Collections.Generic;
using System.Linq;
using ShogunLib.Monads;

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Facade to create chain quickly.
    /// </summary>
    public static class Chain
    {
        #region Void

        /// <summary>
        /// Provides new builder to configure new chain with void output and no input parameters.
        /// </summary>
        /// <returns>Chain builder</returns>
        public static IVoidChainBuilder CreateVoid()
        {
            return new VoidChainBuilder();
        }

        /// <summary>
        /// Provides new builder to configure new chain with void output and one input parameter.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <returns>Chain builder</returns>
        public static IVoidChainBuilder<T1> CreateVoid<T1>()
        {
            return new VoidChainBuilder<T1>();
        }

        /// <summary>
        /// Provides new builder to configure new chain with void output and two input parameters.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
        /// <returns>Chain builder</returns>
        public static IVoidChainBuilder<T1, T2> CreateVoid<T1, T2>()
        {
            return new VoidChainBuilder<T1, T2>();
        }

        /// <summary>
        /// Provides new builder to configure new chain with void output and three input parameters.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
        /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
        /// <returns>Chain builder</returns>
        public static IVoidChainBuilder<T1, T2, T3> CreateVoid<T1, T2, T3>()
        {
            return new VoidChainBuilder<T1, T2, T3>();
        }

        /// <summary>
        /// Provides new builder to configure new chain with void output and four input parameters.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
        /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
        /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
        /// <returns>Chain builder</returns>
        public static IVoidChainBuilder<T1, T2, T3, T4> CreateVoid<T1, T2, T3, T4>()
        {
            return new VoidChainBuilder<T1, T2, T3, T4>();
        }

        /// <summary>
        /// Provides new builder to configure new chain with void output and five input parameters.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
        /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
        /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
        /// <typeparam name="T5">Type of chain fifth input parameter.</typeparam>
        /// <returns>Chain builder</returns>
        public static IVoidChainBuilder<T1, T2, T3, T4, T5> CreateVoid<T1, T2, T3, T4, T5>()
        {
            return new VoidChainBuilder<T1, T2, T3, T4, T5>();
        }

        #endregion

        #region Result

        /// <summary>
        /// Provides new builder to configure new chain with output and no input parameters.
        /// </summary>
        /// <typeparam name="TResult">Type of chain output.</typeparam>
        /// <returns>Chain builder</returns>
        public static IResultChainBuilder<TResult> CreateResult<TResult>()
        {
            return new ResultChainBuilder<TResult>();
        }

        /// <summary>
        /// Provides new builder to configure new chain with output and one input parameter.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="TResult">Type of chain output.</typeparam>
        /// <returns>Chain builder</returns>
        public static IResultChainBuilder<T1, TResult> CreateResult<T1, TResult>()
        {
            return new ResultChainBuilder<T1, TResult>();
        }

        /// <summary>
        /// Provides new builder to configure new chain with output and two input parameters.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
        /// <typeparam name="TResult">Type of chain output.</typeparam>
        /// <returns>Chain builder</returns>
        public static IResultChainBuilder<T1, T2, TResult> CreateResult<T1, T2, TResult>()
        {
            return new ResultChainBuilder<T1, T2, TResult>();
        }

        /// <summary>
        /// Provides new builder to configure new chain with output and three input parameters.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
        /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
        /// <typeparam name="TResult">Type of chain output.</typeparam>
        /// <returns>Chain builder</returns>
        public static IResultChainBuilder<T1, T2, T3, TResult> CreateResult<T1, T2, T3, TResult>()
        {
            return new ResultChainBuilder<T1, T2, T3, TResult>();
        }

        /// <summary>
        /// Provides new builder to configure new chain with output and four input parameters.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
        /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
        /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
        /// <typeparam name="TResult">Type of chain output.</typeparam>
        /// <returns>Chain builder</returns>
        public static IResultChainBuilder<T1, T2, T3, T4, TResult> CreateResult<T1, T2, T3, T4, TResult>()
        {
            return new ResultChainBuilder<T1, T2, T3, T4, TResult>();
        }

        /// <summary>
        ///  Provides new builder to configure new chain with output and five input parameters.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
        /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
        /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
        /// <typeparam name="T5">Type of chain fifth input parameter.</typeparam>
        /// <typeparam name="TResult">Type of chain output.</typeparam>
        /// <returns>Chain builder</returns>
        public static IResultChainBuilder<T1, T2, T3, T4, T5, TResult> CreateResult<T1, T2, T3, T4, T5, TResult>()
        {
            return new ResultChainBuilder<T1, T2, T3, T4, T5, TResult>();
        }

        #endregion
    }

    #region Void 

    /// <summary>
    /// Chain of responsibility with no output and no input parameters.
    /// </summary>
    public class VoidChain : IVoidChain
    {
        private readonly IEnumerable<IVoidLink> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChain"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public VoidChain(IEnumerable<IVoidLink> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        public void Execute()
        {
            _links
                .FirstOrDefault(link => link.Cando())
                .ToMaybe()
                .Do(x => x.Do());
        }
    }

    /// <summary>
    /// Chain of responsibility with no output and one parameter.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    public class VoidChain<T1> : IVoidChain<T1>
    {
        private readonly IEnumerable<IVoidLink<T1>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChain{T1}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public VoidChain(IEnumerable<IVoidLink<T1>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        public void Execute(T1 t1)
        {
            _links
                .FirstOrDefault(link => link.Cando(t1))
                .ToMaybe()
                .Do(x => x.Do(t1));
        }
    }

    /// <summary>
    /// Chain of responsibility with no output and two parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    public class VoidChain<T1, T2> : IVoidChain<T1, T2>
    {
        private readonly IEnumerable<IVoidLink<T1, T2>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChain{T1, T2}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public VoidChain(IEnumerable<IVoidLink<T1, T2>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        public void Execute(T1 t1, T2 t2)
        {
            _links
                .FirstOrDefault(link => link.Cando(t1, t2))
                .ToMaybe()
                .Do(x => x.Do(t1, t2));
        }
    }

    /// <summary>
    /// Chain of responsibility with no output and three parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    public class VoidChain<T1, T2, T3> : IVoidChain<T1, T2, T3>
    {
        private readonly IEnumerable<IVoidLink<T1, T2, T3>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChain{T1, T2, T3}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public VoidChain(IEnumerable<IVoidLink<T1, T2, T3>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        public void Execute(T1 t1, T2 t2, T3 t3)
        {
            _links
                .FirstOrDefault(link => link.Cando(t1, t2, t3))
                .ToMaybe()
                .Do(x => x.Do(t1, t2, t3));
        }
    }

    /// <summary>
    /// Chain of responsibility with no output and four parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    public class VoidChain<T1, T2, T3, T4> : IVoidChain<T1, T2, T3, T4>
    {
        private readonly IEnumerable<IVoidLink<T1, T2, T3, T4>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChain{T1, T2, T3, T4}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public VoidChain(IEnumerable<IVoidLink<T1, T2, T3, T4>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        /// <param name="t4">Fourth input parameter of a chain.</param>
        public void Execute(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            _links
                .FirstOrDefault(link => link.Cando(t1, t2, t3, t4))
                .ToMaybe()
                .Do(x => x.Do(t1, t2, t3, t4));
        }
    }

    /// <summary>
    /// Chain of responsibility with no output and five parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of chain fifth input parameter.</typeparam>
    public class VoidChain<T1, T2, T3, T4, T5> : IVoidChain<T1, T2, T3, T4, T5>
    {
        private readonly IEnumerable<IVoidLink<T1, T2, T3, T4, T5>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChain{T1, T2, T3, T4, T5}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public VoidChain(IEnumerable<IVoidLink<T1, T2, T3, T4, T5>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        /// <param name="t4">Fourth input parameter of a chain.</param>
        /// <param name="t5">Fifth input parameter of a chain.</param>
        public void Execute(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            _links
                .FirstOrDefault(link => link.Cando(t1, t2, t3, t4, t5))
                .ToMaybe()
                .Do(x => x.Do(t1, t2, t3, t4, t5));
        }
    }

    #endregion

    #region Result

    /// <summary>
    /// Chain of responsibility with output and no parameters.
    /// </summary>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public class ResultChain<TResult> : IResultChain<TResult>
    {
        private readonly IEnumerable<IResultLink<TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChain{TResult}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public ResultChain(IEnumerable<IResultLink<TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <returns>Chain handling result.</returns>
        public TResult Execute()
        {
            return
                _links
                    .FirstOrDefault(link => link.Cando())
                    .ToMaybe()
                    .Do(x => x.Do());
        }
    }

    /// <summary>
    /// Chain of responsibility with output and one parameter.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public class ResultChain<T1, TResult> : IResultChain<T1, TResult>
    {
        private readonly IEnumerable<IResultLink<T1, TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChain{T1, TResult}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public ResultChain(IEnumerable<IResultLink<T1, TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <returns>Chain handling result.</returns>
        public TResult Execute(T1 t1)
        {
            return
                _links
                    .FirstOrDefault(link => link.Cando(t1))
                    .ToMaybe()
                    .Do(x => x.Do(t1));
        }
    }

    /// <summary>
    /// Chain of responsibility with output and two parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public class ResultChain<T1, T2, TResult> : IResultChain<T1, T2, TResult>
    {
        private readonly IEnumerable<IResultLink<T1, T2, TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChain{T1, T2, TResult}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public ResultChain(IEnumerable<IResultLink<T1, T2, TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <returns>Chain handling result.</returns>
        public TResult Execute(T1 t1, T2 t2)
        {
            return
                _links
                    .FirstOrDefault(link => link.Cando(t1, t2))
                    .ToMaybe()
                    .Do(x => x.Do(t1, t2));
        }
    }

    /// <summary>
    /// Chain of responsibility with output and three parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public class ResultChain<T1, T2, T3, TResult> : IResultChain<T1, T2, T3, TResult>
    {
        private readonly IEnumerable<IResultLink<T1, T2, T3, TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChain{T1, T2, T3, TResult}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public ResultChain(IEnumerable<IResultLink<T1, T2, T3, TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        /// <returns>Chain handling result.</returns>
        public TResult Execute(T1 t1, T2 t2, T3 t3)
        {
            return
                _links
                    .FirstOrDefault(link => link.Cando(t1, t2, t3))
                    .ToMaybe()
                    .Do(x => x.Do(t1, t2, t3));
        }
    }

    /// <summary>
    /// Chain of responsibility with output and four parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public class ResultChain<T1, T2, T3, T4, TResult> : IResultChain<T1, T2, T3, T4, TResult>
    {
        private readonly IEnumerable<IResultLink<T1, T2, T3, T4, TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChain{T1, T2, T3, T4, TResult}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public ResultChain(IEnumerable<IResultLink<T1, T2, T3, T4, TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        /// <param name="t4">Fourth input parameter of a chain.</param>
        /// <returns>Chain handling result.</returns>
        public TResult Execute(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return
                _links
                    .FirstOrDefault(link => link.Cando(t1, t2, t3, t4))
                    .ToMaybe()
                    .Do(x => x.Do(t1, t2, t3, t4));
        }
    }

    /// <summary>
    /// Chain of responsibility with output and five parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of chain fifth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public class ResultChain<T1, T2, T3, T4, T5, TResult> : IResultChain<T1, T2, T3, T4, T5, TResult>
    {
        private readonly IEnumerable<IResultLink<T1, T2, T3, T4, T5, TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChain{T1, T2, T3, T4, T5, TResult}"/> class.
        /// </summary>
        /// <param name="links">Links for the Chain of responsibility.</param>
        public ResultChain(IEnumerable<IResultLink<T1, T2, T3, T4, T5, TResult>> links)
        {
            links.ValidateNull(nameof(links));

            _links = links;
        }

        /// <summary>
        /// Handle request.
        /// </summary>
        /// <param name="t1">First input parameter of a chain.</param>
        /// <param name="t2">Second input parameter of a chain.</param>
        /// <param name="t3">Third input parameter of a chain.</param>
        /// <param name="t4">Fourth input parameter of a chain.</param>
        /// <param name="t5">Fifth input parameter of a chain.</param>
        /// <returns>Chain handling result.</returns>
        public TResult Execute(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return
                _links
                    .FirstOrDefault(link => link.Cando(t1, t2, t3, t4, t5))
                    .ToMaybe()
                    .Do(x => x.Do(t1, t2, t3, t4, t5));
        }
    }

    #endregion
}
