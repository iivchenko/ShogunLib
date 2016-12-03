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
    /// Provides functionality to configure new chain with no output and no parameters.
    /// </summary>
    public sealed class VoidChainBuilder : IVoidChainBuilder
    {
        private readonly IList<IVoidLink> _links;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidChainBuilder"/> class.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Initializes a new instance of the <see cref="VoidChainBuilder{T1}"/> class.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Initializes a new instance of the <see cref="VoidChainBuilder{T1, T2}"/> class.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Initializes a new instance of the <see cref="VoidChainBuilder{T1, T2, T3}"/> class.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2, T3>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Initializes a new instance of the <see cref="VoidChainBuilder{T1, T2, T3, T4}"/> class.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2, T3, T4>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Initializes a new instance of the <see cref="VoidChainBuilder{T1, T2, T3, T4, T5}"/> class.
        /// </summary>
        public VoidChainBuilder()
        {
            _links = new List<IVoidLink<T1, T2, T3, T4, T5>>();
        }

        /// <summary>
        /// Add a link (divided into separate delegates) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
        /// Add a link (divided into separate instances) to a chain.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
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
}
