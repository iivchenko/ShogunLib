// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;

namespace ShogunLib.LINQ
{
    /// <summary>
    /// Provides extension methods for <see cref="IEnumerable{T}"/>
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Apply an action for each element of the sequence.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">An <see cref="IEnumerable{T}"/> that contains the elements to apply the action to.</param>
        /// <param name="action">A function to affect each element of the sequence.</param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            source.ValidateNull(nameof(source));
            action.ValidateNull(nameof(action));

            foreach (var item in source)
            {
                action(item);
            }
        }
    }
}