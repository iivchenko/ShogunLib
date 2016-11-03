namespace ShogunLib.Patterns.ChainOfResponsibility
{
    #region Void 

    /// <summary>
    /// 
    /// </summary>
    public interface IVoidLink : ICan, IVoidDo
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    public interface IVoidLink<in T1> : ICan<T1>, IVoidDo<T1>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public interface IVoidLink<in T1, in T2> : ICan<T1, T2>, IVoidDo<T1, T2>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    public interface IVoidLink<in T1, in T2, in T3> : ICan<T1, T2, T3>, IVoidDo<T1, T2, T3>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    public interface IVoidLink<in T1, in T2, in T3, in T4> : ICan<T1, T2, T3, T4>, IVoidDo<T1, T2, T3, T4>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    public interface IVoidLink<in T1, in T2, in T3, in T4, in T5> : ICan<T1, T2, T3, T4, T5>, IVoidDo<T1, T2, T3, T4, T5>
    {
    }

    #endregion

    #region Result

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultLink <out TResult>: ICan, IResultDo<TResult>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultLink<in T1, out TResult> : ICan<T1>, IResultDo<T1, TResult>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultLink<in T1, in T2, out TResult> : ICan<T1, T2>, IResultDo<T1, T2, TResult>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultLink<in T1, in T2, in T3, out TResult> : ICan<T1, T2, T3>, IResultDo<T1, T2, T3, TResult>
    {
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IResultLink<in T1, in T2, in T3, in T4, out TResult> : ICan<T1, T2, T3, T4>, IResultDo<T1, T2, T3, T4, TResult>
    {
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
    public interface IResultLink<in T1, in T2, in T3, in T4, in T5, out TResult> : ICan<T1, T2, T3, T4, T5>, IResultDo<T1, T2, T3, T4, T5, TResult>
    {
    }

    #endregion
}