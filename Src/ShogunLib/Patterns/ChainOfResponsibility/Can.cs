// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>
using System;

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Can : ICan
    {
        private readonly Func<bool> _cando;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        public Can(Func<bool> cando)
        {
            _cando = cando;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Cando()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    public sealed class Can<T1> : ICan<T1>
    {
        private readonly Func<T1, bool> _cando;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        public Can(Func<T1, bool> cando)
        {
            _cando = cando;
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
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public sealed class Can<T1, T2> : ICan<T1, T2>
    {
        private readonly Func<T1, T2, bool> _cando;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        public Can(Func<T1, T2, bool> cando)
        {
            _cando = cando;
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
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    public sealed class Can<T1, T2, T3> : ICan<T1, T2, T3>
    {
        private readonly Func<T1, T2, T3, bool> _cando;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        public Can(Func<T1, T2, T3, bool> cando)
        {
            _cando = cando;
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
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    public sealed class Can<T1, T2, T3, T4> : ICan<T1, T2, T3, T4>
    {
        private readonly Func<T1, T2, T3, T4, bool> _cando;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        public Can(Func<T1, T2, T3, T4, bool> cando)
        {
            _cando = cando;
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
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    public sealed class Can<T1, T2, T3, T4, T5> : ICan<T1, T2, T3, T4, T5>
    {
        private readonly Func<T1, T2, T3, T4, T5, bool> _cando;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cando"></param>
        public Can(Func<T1, T2, T3, T4, T5, bool> cando)
        {
            _cando = cando;
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
    }
}
