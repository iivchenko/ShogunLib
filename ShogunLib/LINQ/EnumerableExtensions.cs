// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
            source.ValidateNull("source");
            action.ValidateNull("action");

            foreach (var item in source)
            {
                action(item);
            }
        }

        /// <summary>
        /// Apply an action for each element of the sequence and returns new processed sequence.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">An <see cref="IEnumerable{T}"/> that contains the elements to apply the action to.</param>
        /// <param name="action">A function to affect each element of the sequence. Returns new processed element.</param>
        /// <returns>New sequence with processed elements.</returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Func<T, T> action)
        {
            source.ValidateNull("source");
            action.ValidateNull("action");

            var collection = new Collection<T>();

            foreach (var item in source)
            {
                collection.Add(action(item));
            }

            return collection;
        }
    }
}