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
}
