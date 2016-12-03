// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

namespace ShogunLib.Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Facade to create chain quickly.
    /// </summary>
    public static class ChainFactory
    {
        #region Void

        /// <summary>
        /// Provides new builder to configure new chain with void output and no input parameters.
        /// </summary>
        /// <returns>Chain builder</returns>
        public static IVoidChainBuilder CreateVoidBuilder()
        {
            return new VoidChainBuilder();
        }

        /// <summary>
        /// Provides new builder to configure new chain with void output and one input parameter.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <returns>Chain builder</returns>
        public static IVoidChainBuilder<T1> CreateVoidBuilder<T1>()
        {
            return new VoidChainBuilder<T1>();
        }

        /// <summary>
        /// Provides new builder to configure new chain with void output and two input parameters.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="T2">Type of chain second input parameter.</typeparam>
        /// <returns>Chain builder</returns>
        public static IVoidChainBuilder<T1, T2> CreateVoidBuilder<T1, T2>()
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
        public static IVoidChainBuilder<T1, T2, T3> CreateVoidBuilder<T1, T2, T3>()
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
        public static IVoidChainBuilder<T1, T2, T3, T4> CreateVoidBuilder<T1, T2, T3, T4>()
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
        public static IVoidChainBuilder<T1, T2, T3, T4, T5> CreateVoidBuilder<T1, T2, T3, T4, T5>()
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
        public static IResultChainBuilder<TResult> CreateResultBuilder<TResult>()
        {
            return new ResultChainBuilder<TResult>();
        }

        /// <summary>
        /// Provides new builder to configure new chain with output and one input parameter.
        /// </summary>
        /// <typeparam name="T1">Type of chain first input parameter.</typeparam>
        /// <typeparam name="TResult">Type of chain output.</typeparam>
        /// <returns>Chain builder</returns>
        public static IResultChainBuilder<T1, TResult> CreateResultBuilder<T1, TResult>()
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
        public static IResultChainBuilder<T1, T2, TResult> CreateResultBuilder<T1, T2, TResult>()
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
        public static IResultChainBuilder<T1, T2, T3, TResult> CreateResultBuilder<T1, T2, T3, TResult>()
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
        public static IResultChainBuilder<T1, T2, T3, T4, TResult> CreateResultBuilder<T1, T2, T3, T4, TResult>()
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
        public static IResultChainBuilder<T1, T2, T3, T4, T5, TResult> CreateResultBuilder<T1, T2, T3, T4, T5, TResult>()
        {
            return new ResultChainBuilder<T1, T2, T3, T4, T5, TResult>();
        }

        #endregion
    }
}
