namespace ShogunLib.Patterns.ChainOfResponsibility
{
    #region Void 

    /// <summary>
    /// Chain link with no output and no input parameters.
    /// </summary>
    public interface IVoidLink : ICan, IVoidDo
    {
    }

    /// <summary>
    /// Chain link with no output and one input parameter.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    public interface IVoidLink<in T1> : ICan<T1>, IVoidDo<T1>
    {
    }

    /// <summary>
    /// Chain link with no output and two input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    public interface IVoidLink<in T1, in T2> : ICan<T1, T2>, IVoidDo<T1, T2>
    {
    }

    /// <summary>
    /// Chain link with no output and three input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    public interface IVoidLink<in T1, in T2, in T3> : ICan<T1, T2, T3>, IVoidDo<T1, T2, T3>
    {
    }

    /// <summary>
    /// Chain link with no output and four input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    public interface IVoidLink<in T1, in T2, in T3, in T4> : ICan<T1, T2, T3, T4>, IVoidDo<T1, T2, T3, T4>
    {
    }

    /// <summary>
    /// Chain link with no output and five input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of link fifth input parameter.</typeparam>
    public interface IVoidLink<in T1, in T2, in T3, in T4, in T5> : ICan<T1, T2, T3, T4, T5>, IVoidDo<T1, T2, T3, T4, T5>
    {
    }

    #endregion

    #region Result

    /// <summary>
    /// Chain link with output and no input parameters.
    /// </summary>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public interface IResultLink <out TResult>: ICan, IResultDo<TResult>
    {
    }

    /// <summary>
    /// Chain link with output and one input parameter.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public interface IResultLink<in T1, out TResult> : ICan<T1>, IResultDo<T1, TResult>
    {
    }

    /// <summary>
    /// Chain link with output and two input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public interface IResultLink<in T1, in T2, out TResult> : ICan<T1, T2>, IResultDo<T1, T2, TResult>
    {
    }

    /// <summary>
    /// Chain link with output and three input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public interface IResultLink<in T1, in T2, in T3, out TResult> : ICan<T1, T2, T3>, IResultDo<T1, T2, T3, TResult>
    {
    }

    /// <summary>
    /// Chain link with output and four input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public interface IResultLink<in T1, in T2, in T3, in T4, out TResult> : ICan<T1, T2, T3, T4>, IResultDo<T1, T2, T3, T4, TResult>
    {
    }

    /// <summary>
    /// Chain link with output and five input parameters.
    /// </summary>
    /// <typeparam name="T1">Type of link first input parameter.</typeparam>
    /// <typeparam name="T2">Type of link second input parameter.</typeparam>
    /// <typeparam name="T3">Type of link third input parameter.</typeparam>
    /// <typeparam name="T4">Type of link fourth input parameter.</typeparam>
    /// <typeparam name="T5">Type of link fifth input parameter.</typeparam>
    /// <typeparam name="TResult">Type of link output.</typeparam>
    public interface IResultLink<in T1, in T2, in T3, in T4, in T5, out TResult> : ICan<T1, T2, T3, T4, T5>, IResultDo<T1, T2, T3, T4, T5, TResult>
    {
    }

    #endregion
}