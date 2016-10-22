// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;

namespace ShogunLib.Monads
{
    /// <summary>
    /// Represents simple implementation of maybe monad principles.
    /// </summary>
    public static class MaybeExtensions
    {
        /// <summary>
        /// Wraps <paramref name="source"/> to Maybe monad.
        /// </summary>
        /// <typeparam name="TSource">Type of <paramref name="source"/> value.</typeparam>
        /// <param name="source">The value to be wrapped.</param>
        /// <returns>Wrapped <paramref name="source"/> to Maybe monad.</returns>
        public static Maybe<TSource> ToMaybe<TSource>(this TSource source)
            where TSource : class
        {
            return new Maybe<TSource>(source);
        }

        /// <summary>
        /// Unwraps value from Maybe monad. If Maybe doesn't have value then default value will be returned.
        /// </summary>
        /// <typeparam name="TResult">Type of <paramref name="result"/> value.</typeparam>
        /// <param name="result">The value to be unwrapped.</param>
        /// <returns>Unwrapped <see cref="Maybe{T}.Value"/> of <see cref="Maybe{T}"/> monad.</returns>
        public static TResult Return<TResult>(this Maybe<TResult> result)
            where TResult : class
        {
            return result.HasValue
                ? result.Value
                : default(TResult);
        }

        /// <summary>
        /// Apply <paramref name="func"/> to the Monad value if it exists.
        /// </summary>
        /// <typeparam name="TSource">Type of <paramref name="source"/> value.</typeparam>
        /// <typeparam name="TResult">Type of <paramref name="func"/> result.</typeparam>
        /// <param name="source">Maybe monad.</param>
        /// <param name="func">Function to be applied to <paramref name="source"/> value.</param>
        /// <returns>Resulting monad maybe with new wrapped value.</returns>
        public static Maybe<TResult> Bind<TSource, TResult>(this Maybe<TSource> source, Func<TSource, TResult> func)
        {
            return source.HasValue
                ? new Maybe<TResult>(func(source.Value))
                : new Maybe<TResult>(default(TResult));
        }

        /// <summary>
        /// Apply <paramref name="action"/> to the Monad value if it exists.
        /// </summary>
        /// <typeparam name="TSource">Type of <paramref name="source"/> value.</typeparam>
        /// <param name="source">Maybe monad.</param>
        /// <param name="action">Action to be applied to <paramref name="source"/> value.</param>
        public static void Do<TSource>(this Maybe<TSource> source, Action<TSource> action)
        {
            if (source.HasValue)
            {
                action(source.Value);
            }
        }
    }
}