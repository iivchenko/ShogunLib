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
    /// Provides functionality to configure new chain with no output and no parameters.
    /// </summary>
    public sealed class VoidChainBuilder : IVoidChainBuilder
    {
        private readonly IList<IVoidLink> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChainBuilder"/> type.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder Add(Func<bool> cando, Action voidDo)
        {
            _links.Add(new VoidLink(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder Add(IVoidLink link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder Add(ICan cando, IVoidDo voidDo)
        {
            _links.Add(new VoidLink(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IVoidChain Build()
        {
            return new VoidChain(_links);
        }
    }

    /// <summary>
    /// Provides functionality to configure new chain with no output and one parameter.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    public sealed class VoidChainBuilder<T1> : IVoidChainBuilder<T1>
    {
        private readonly IList<IVoidLink<T1>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChainBuilder{T1}"/> type.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1> Add(Func<T1, bool> cando, Action<T1> voidDo)
        {
            _links.Add(new VoidLink<T1>(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1> Add(IVoidLink<T1> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1> Add(ICan<T1> cando, IVoidDo<T1> voidDo)
        {
            _links.Add(new VoidLink<T1>(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IVoidChain<T1> Build()
        {
            return new VoidChain<T1>(_links);
        }
    }

    /// <summary>
    /// Provides functionality to configure new chain with no output and two parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    public sealed class VoidChainBuilder<T1, T2> : IVoidChainBuilder<T1, T2>
    {
        private readonly IList<IVoidLink<T1, T2>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChainBuilder{T1, T2}"/> type.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2> Add(Func<T1, T2, bool> cando, Action<T1, T2> voidDo)
        {
            _links.Add(new VoidLink<T1, T2>(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2> Add(IVoidLink<T1, T2> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2> Add(ICan<T1, T2> cando, IVoidDo<T1, T2> voidDo)
        {
            _links.Add(new VoidLink<T1, T2>(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IVoidChain<T1, T2> Build()
        {
            return new VoidChain<T1, T2>(_links);
        }
    }

    /// <summary>
    /// Provides functionality to configure new chain with no output and three parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    public sealed class VoidChainBuilder<T1, T2, T3> : IVoidChainBuilder<T1, T2, T3>
    {
        private readonly IList<IVoidLink<T1, T2, T3>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChainBuilder{T1, T2, T3}"/> type.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2, T3>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2, T3> Add(Func<T1, T2, T3, bool> cando, Action<T1, T2, T3> voidDo)
        {
            _links.Add(new VoidLink<T1, T2, T3>(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2, T3> Add(IVoidLink<T1, T2, T3> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2, T3> Add(ICan<T1, T2, T3> cando, IVoidDo<T1, T2, T3> voidDo)
        {
            _links.Add(new VoidLink<T1, T2, T3>(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IVoidChain<T1, T2, T3> Build()
        {
            return new VoidChain<T1, T2, T3>(_links);
        }
    }

    /// <summary>
    /// Provides functionality to configure new chain with no output and four parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    public sealed class VoidChainBuilder<T1, T2, T3, T4> : IVoidChainBuilder<T1, T2, T3, T4>
    {
        private readonly IList<IVoidLink<T1, T2, T3, T4>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChainBuilder{T1, T2, T3, T4}"/> type.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2, T3, T4>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2, T3, T4> Add(Func<T1, T2, T3, T4, bool> cando, Action<T1, T2, T3, T4> voidDo)
        {
            _links.Add(new VoidLink<T1, T2, T3, T4>(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2, T3, T4> Add(IVoidLink<T1, T2, T3, T4> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2, T3, T4> Add(ICan<T1, T2, T3, T4> cando, IVoidDo<T1, T2, T3, T4> voidDo)
        {
            _links.Add(new VoidLink<T1, T2, T3, T4>(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IVoidChain<T1, T2, T3, T4> Build()
        {
            return new VoidChain<T1, T2, T3, T4>(_links);
        }
    }

    /// <summary>
    /// Provides functionality to configure new chain with no output and five parameters.
    /// </summary>
    /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
    /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
    /// <typeparam name="T3">Type of chain third input parameter.</typeparam>
    /// <typeparam name="T4">Type of chain fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of chain fifth input parameter.</typeparam>
    public sealed class VoidChainBuilder<T1, T2, T3, T4, T5> : IVoidChainBuilder<T1, T2, T3, T4, T5>
    {
        private readonly IList<IVoidLink<T1, T2, T3, T4, T5>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChainBuilder{T1, T2, T3, T4, T5}"/> type.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2, T3, T4, T5>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2, T3, T4, T5> Add(Func<T1, T2, T3, T4, T5, bool> cando, Action<T1, T2, T3, T4, T5> voidDo)
        {
            _links.Add(new VoidLink<T1, T2, T3, T4, T5>(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Add a link to a chain.
        /// </summary>
        /// <param name="link">Link to add.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2, T3, T4, T5> Add(IVoidLink<T1, T2, T3, T4, T5> link)
        {
            link.ValidateNull(nameof(link));

            _links.Add(link);

            return this;
        }

        /// <summary>
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        public IVoidChainBuilder<T1, T2, T3, T4, T5> Add(ICan<T1, T2, T3, T4, T5> cando, IVoidDo<T1, T2, T3, T4, T5> voidDo)
        {
            _links.Add(new VoidLink<T1, T2, T3, T4, T5>(cando, voidDo));

            return this;
        }

        /// <summary>
        /// Creates new and chain.
        /// </summary>
        /// <returns>New chain.</returns>
        public IVoidChain<T1, T2, T3, T4, T5> Build()
        {
            return new VoidChain<T1, T2, T3, T4, T5>(_links);
        }
    }

    #endregion

    #region Result

    /// <summary>
    /// Provides functionality to configure new chain with output and no parameters.
    /// </summary>
    /// <typeparam name="TResult">Type of chain output.</typeparam>
    public sealed class ResultChainBuilder<TResult> : IResultChainBuilder<TResult>
    {
        private readonly IList<IResultLink<TResult>> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultChainBuilder{TResult}"/> type.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<TResult>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Initializes a new instance of the <see cref="ResultChainBuilder{T1, TResult}"/> type.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, TResult>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Initializes a new instance of the <see cref="ResultChainBuilder{T1, T2, TResult}"/> type.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, TResult>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Initializes a new instance of the <see cref="ResultChainBuilder{T1, T2, T3, TResult}"/> type.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, T3, TResult>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Initializes a new instance of the <see cref="ResultChainBuilder{T1, T2, T3, T4, TResult}"/> type.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, T3, T4, TResult>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Initializes a new instance of the <see cref="ResultChainBuilder{T1, T2, T3, T4, T5, TResult}"/> type.
        /// </summary>
        public ResultChainBuilder()
        {
            _links = new List<IResultLink<T1, T2, T3, T4, T5, TResult>>();
        }

        /// <summary>
        /// Add a link (splited into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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
        /// Add a link (splited into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines wherther a link can handle input request.</param>
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

    #endregion
}
