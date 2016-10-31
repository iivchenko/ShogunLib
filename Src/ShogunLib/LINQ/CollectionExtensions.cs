// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System.Collections.Generic;

namespace ShogunLib.LINQ
{
    /// <summary>
    /// Provides extension methods for <see cref="ICollection{T}"/>
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Adds <paramref name="values"/> to the <paramref name="source"/> collection.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">Collection where new elements will be added.</param>
        /// <param name="values">New elements to add.</param>
        public static void AddRange<T>(this ICollection<T> source, IEnumerable<T> values)
        {
            source.ValidateNull(nameof(source));
            values.ValidateNull(nameof(values));

            foreach (var value in values)
            {
                source.Add(value);
            }
        }
    }
}
