// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Chain link with no output and no input parameters.
    /// </summary>
    public sealed class VoidLink : IVoidLink
    {
        private readonly ICan _cando;
        private readonly IVoidDo _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(Func<bool> cando, Action voidDo)
            : this(new Can(cando), new VoidDo(voidDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(ICan cando, IVoidDo voidDo)
        {
            cando.ValidateNull(nameof(cando));
            voidDo.ValidateNull(nameof(voidDo));

            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando()
        {
            return _cando.Cando();
        }

        /// <summary>
        /// Link action.
        /// </summary>
        public void Do()
        {
            _voidDo.Do();
        }
    }

    /// <summary>
    /// Chain link with no output and one input parameter.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    public sealed class VoidLink<T1> : IVoidLink<T1>
    {
        private readonly ICan<T1> _cando;
        private readonly IVoidDo<T1> _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink{T1}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(Func<T1, bool> cando, Action<T1> voidDo)
            : this(new Can<T1>(cando), new VoidDo<T1>(voidDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink{T1}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(ICan<T1> cando, IVoidDo<T1> voidDo)
        {
            cando.ValidateNull(nameof(cando));
            voidDo.ValidateNull(nameof(voidDo));

            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1)
        {
            return _cando.Cando(t1);
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        public void Do(T1 t1)
        {
            _voidDo.Do(t1);
        }
    }

    /// <summary>
    /// Chain link with no output and two input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    public sealed class VoidLink<T1, T2> : IVoidLink<T1, T2>
    {
        private readonly ICan<T1, T2> _cando;
        private readonly IVoidDo<T1, T2> _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink{T1, T2}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(Func<T1, T2, bool> cando, Action<T1, T2> voidDo)
            : this(new Can<T1, T2>(cando), new VoidDo<T1, T2>(voidDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink{T1, T2}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(ICan<T1, T2> cando, IVoidDo<T1, T2> voidDo)
        {
            cando.ValidateNull(nameof(cando));
            voidDo.ValidateNull(nameof(voidDo));

            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2)
        {
            return _cando.Cando(t1, t2);
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        public void Do(T1 t1, T2 t2)
        {
            _voidDo.Do(t1, t2);
        }
    }

    /// <summary>
    /// Chain link with no output and three input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    public sealed class VoidLink<T1, T2, T3> : IVoidLink<T1, T2, T3>
    {
        private readonly ICan<T1, T2, T3> _cando;
        private readonly IVoidDo<T1, T2, T3> _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink{T1, T2, T3}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(Func<T1, T2, T3, bool> cando, Action<T1, T2, T3> voidDo)
            : this(new Can<T1, T2, T3>(cando), new VoidDo<T1, T2, T3>(voidDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink{T1, T2, T3}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(ICan<T1, T2, T3> cando, IVoidDo<T1, T2, T3> voidDo)
        {
            cando.ValidateNull(nameof(cando));
            voidDo.ValidateNull(nameof(voidDo));

            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2, T3 t3)
        {
            return _cando.Cando(t1, t2, t3);
        }

        /// <summary>
        /// Link action.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        public void Do(T1 t1, T2 t2, T3 t3)
        {
            _voidDo.Do(t1, t2, t3);
        }
    }

    /// <summary>
    /// Chain link with no output and four input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    public sealed class VoidLink<T1, T2, T3, T4> : IVoidLink<T1, T2, T3, T4>
    {
        private readonly ICan<T1, T2, T3, T4> _cando;
        private readonly IVoidDo<T1, T2, T3, T4> _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink{T1, T2, T3, T4}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(Func<T1, T2, T3, T4, bool> cando, Action<T1, T2, T3, T4> voidDo)
            : this(new Can<T1, T2, T3, T4>(cando), new VoidDo<T1, T2, T3, T4>(voidDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink{T1, T2, T3, T4}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(ICan<T1, T2, T3, T4> cando, IVoidDo<T1, T2, T3, T4> voidDo)
        {
            cando.ValidateNull(nameof(cando));
            voidDo.ValidateNull(nameof(voidDo));

            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return _cando.Cando(t1, t2, t3, t4);
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
            _voidDo.Do(t1, t2, t3, t4);
        }
    }

    /// <summary>
    /// Chain link with no output and five input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of link fifth input parameter.</typeparam>
    public sealed class VoidLink<T1, T2, T3, T4, T5> : IVoidLink<T1, T2, T3, T4, T5>
    {
        private readonly ICan<T1, T2, T3, T4, T5> _cando;
        private readonly IVoidDo<T1, T2, T3, T4, T5> _voidDo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink{T1, T2, T3, T4, T5}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(Func<T1, T2, T3, T4, T5, bool> cando, Action<T1, T2, T3, T4, T5> voidDo)
            : this(new Can<T1, T2, T3, T4, T5>(cando), new VoidDo<T1, T2, T3, T4, T5>(voidDo))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidLink{T1, T2, T3, T4, T5}"/> class.
        /// </summary>
        /// <param name="cando">Predicate that determines whether a link can handle input request.</param>
        /// <param name="voidDo">Link action.</param>
        public VoidLink(ICan<T1, T2, T3, T4, T5> cando, IVoidDo<T1, T2, T3, T4, T5> voidDo)
        {
            cando.ValidateNull(nameof(cando));
            voidDo.ValidateNull(nameof(voidDo));

            _cando = cando;
            _voidDo = voidDo;
        }

        /// <summary>
        /// Determines whether a link can handle input request.
        /// </summary>
        /// <param name="t1">First input parameter of a link.</param>
        /// <param name="t2">Second input parameter of a link.</param>
        /// <param name="t3">Third input parameter of a link.</param>
        /// <param name="t4">Fourth input parameter of a link.</param>
        /// <param name="t5">Fifth input parameter of a link.</param>
        /// <returns>true - link can handle; false - link can't handle</returns>
        public bool Cando(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return _cando.Cando(t1, t2, t3, t4, t5);
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
            _voidDo.Do(t1, t2, t3, t4, t5);
        }
    }
}
