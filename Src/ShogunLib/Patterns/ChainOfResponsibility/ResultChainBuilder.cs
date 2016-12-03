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
    /// Provides functionality to configure new chain with output and no parameters.
    /// </summary>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public sealed class ResultChainBuilder<TResult> : IResultChainBuilder<TResult>
    {
        private readonly IList<IResultLink<TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChainBuilder{TResult}"/> class.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<TResult>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<TResult> Add(Func<bool> cando, Func<TResult> resultDo)
        {
            _links.Add(new ResultLink<TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<TResult> Add(IResultLink<TResult> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<TResult> Add(ICan cando, IResultDo<TResult> resultDo)
        {
            _links.Add(new ResultLink<TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IResultChain<TResult> Build()
        {
            return new ResultChain<TResult>(_links);
        }
    }

    /// <summary>
    /// Provides functionality to configure new chain with output and one parameter.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public sealed class ResultChainBuilder<T1, TResult> : IResultChainBuilder<T1, TResult>
    {
        private readonly IList<IResultLink<T1, TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChainBuilder{T1, TResult}"/> class.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, TResult>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, TResult> Add(Func<T1, bool> cando, Func<T1, TResult> resultDo)
        {
            _links.Add(new ResultLink<T1, TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, TResult> Add(IResultLink<T1, TResult> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, TResult> Add(ICan<T1> cando, IResultDo<T1, TResult> resultDo)
        {
            _links.Add(new ResultLink<T1, TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IResultChain<T1, TResult> Build()
        {
            return new ResultChain<T1, TResult>(_links);
        }
    }

    /// <summary>
    /// Provides functionality to configure new chain with output and two parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public sealed class ResultChainBuilder<T1, T2, TResult> : IResultChainBuilder<T1, T2, TResult>
    {
        private readonly IList<IResultLink<T1, T2, TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChainBuilder{T1, T2, TResult}"/> class.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, TResult>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, TResult> Add(Func<T1, T2, bool> cando, Func<T1, T2, TResult> resultDo)
        {
            _links.Add(new ResultLink<T1, T2, TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, TResult> Add(IResultLink<T1, T2, TResult> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, TResult> Add(ICan<T1, T2> cando, IResultDo<T1, T2, TResult> resultDo)
        {
            _links.Add(new ResultLink<T1, T2, TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IResultChain<T1, T2, TResult> Build()
        {
            return new ResultChain<T1, T2, TResult>(_links);
        }
    }

    /// <summary>
    /// Provides functionality to configure new chain with output and three parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public sealed class ResultChainBuilder<T1, T2, T3, TResult> : IResultChainBuilder<T1, T2, T3, TResult>
    {
        private readonly IList<IResultLink<T1, T2, T3, TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChainBuilder{T1, T2, T3, TResult}"/> class.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, T3, TResult>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, T3, TResult> Add(Func<T1, T2, T3, bool> cando, Func<T1, T2, T3, TResult> resultDo)
        {
            _links.Add(new ResultLink<T1, T2, T3, TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, T3, TResult> Add(IResultLink<T1, T2, T3, TResult> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, T3, TResult> Add(ICan<T1, T2, T3> cando, IResultDo<T1, T2, T3, TResult> resultDo)
        {
            _links.Add(new ResultLink<T1, T2, T3, TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IResultChain<T1, T2, T3, TResult> Build()
        {
            return new ResultChain<T1, T2, T3, TResult>(_links);
        }
    }

    /// <summary>
    /// Provides functionality to configure new chain with output and four parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public sealed class ResultChainBuilder<T1, T2, T3, T4, TResult> : IResultChainBuilder<T1, T2, T3, T4, TResult>
    {
        private readonly IList<IResultLink<T1, T2, T3, T4, TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChainBuilder{T1, T2, T3, T4, TResult}"/> class.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, T3, T4, TResult>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, T3, T4, TResult> Add(Func<T1, T2, T3, T4, bool> cando, Func<T1, T2, T3, T4, TResult> resultDo)
        {
            _links.Add(new ResultLink<T1, T2, T3, T4, TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, T3, T4, TResult> Add(IResultLink<T1, T2, T3, T4, TResult> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, T3, T4, TResult> Add(ICan<T1, T2, T3, T4> cando, IResultDo<T1, T2, T3, T4, TResult> resultDo)
        {
            _links.Add(new ResultLink<T1, T2, T3, T4, TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IResultChain<T1, T2, T3, T4, TResult> Build()
        {
            return new ResultChain<T1, T2, T3, T4, TResult>(_links);
        }
    }

    /// <summary>
    /// Provides functionality to configure new chain with output and five parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of chain fifth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public sealed class ResultChainBuilder<T1, T2, T3, T4, T5, TResult> : IResultChainBuilder<T1, T2, T3, T4, T5, TResult>
    {
        private readonly IList<IResultLink<T1, T2, T3, T4, T5, TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChainBuilder{T1, T2, T3, T4, T5, TResult}"/> class.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, T3, T4, T5, TResult>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(Func<T1, T2, T3, T4, T5, bool> cando, Func<T1, T2, T3, T4, T5, TResult> resultDo)
        {
            _links.Add(new ResultLink<T1, T2, T3, T4, T5, TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(IResultLink<T1, T2, T3, T4, T5, TResult> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="resultDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IResultChainBuilder<T1, T2, T3, T4, T5, TResult> Add(ICan<T1, T2, T3, T4, T5> cando, IResultDo<T1, T2, T3, T4, T5, TResult> resultDo)
        {
            _links.Add(new ResultLink<T1, T2, T3, T4, T5, TResult>(cando, resultDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IResultChain<T1, T2, T3, T4, T5, TResult> Build()
        {
            return new ResultChain<T1, T2, T3, T4, T5, TResult>(_links);
        }
    }
}
