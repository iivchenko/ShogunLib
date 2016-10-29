// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ShogunLib
{
    /// <summary>
    /// Contains useful extensions to convert objects and collections into string representation.
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Converts <paramref name="source"/> into string representation.
        /// </summary>
        /// <typeparam name="T">Type of the <paramref name="source"/></typeparam>
        /// <param name="source">Object that will be converted into string.</param>
        /// <returns>String representation of the <paramref name="source"/></returns>
        public static string AsString<T>(this T source)
        {
            return source.ToString();
        }

        /// <summary>
        /// Converts <paramref name="source"/> into string representation.
        /// </summary>
        /// <typeparam name="T">Type of the <paramref name="source"/></typeparam>
        /// <param name="source">Object that will be converted into string.</param>
        /// <param name="transformer">Transforms <paramref name="source"/> into string representation.</param>
        /// <returns>String representation of the <paramref name="source"/></returns>
        public static string AsString<T>(this T source, Func<T, string> transformer)
        {
            transformer.ValidateNull(nameof(transformer));

            return transformer(source);
        }
        
        /// <summary>
        /// Converts <paramref name="source"/> into string representation.
        /// </summary>
        /// <typeparam name="T">Type of the <paramref name="source"/></typeparam>
        /// <param name="source">Object that will be converted into string.</param>
        /// <param name="template">Contains pattern with placeholders which will be used for resulted string.</param>
        /// <param name="selector">Provides functionality to handle <paramref name="source"/> to fill <paramref name="template"/> placeholders.</param>
        /// <returns>String representation of the <paramref name="source"/></returns>
        public static string AsString<T>(this T source, string template, params Func<T, object>[] selector)
        {
            template.ValidateStringEmpty(nameof(template));

            var args = selector.Length > 0
                ? new object[selector.Length]
                : null;

            for (var i = 0; i < selector.Length; i++)
            {
                args[i] = selector[i](source);
            }

            return args == null
                ? string.Format(CultureInfo.InvariantCulture, template)
                : string.Format(CultureInfo.InvariantCulture, template, args);
        }

        /// <summary>
        /// Concatenates the members of the <paramref name="source"/>, using the specified <paramref name="separator"/> between each member.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">A set of the objects to concatenate.</param>
        /// <param name="separator">The string to use as a separator.</param>
        /// <returns>A string that consists of the members of <paramref name="source"/> delimited by the <paramref name="separator"/> string. If <paramref name="source"/> has no members, the method returns <see cref="System.String.Empty"/>.</returns>
        public static string JoinString<T>(this IEnumerable<T> source, string separator)
        {
            source.ValidateNull(nameof(source));
            separator.ValidateNull(nameof(separator));

            return string.Join(separator, source);
        }

        /// <summary>
        /// Concatenates the members of the <paramref name="source"/>, using the specified <paramref name="separator"/> between each member.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">A set of the objects to concatenate.</param>
        /// <param name="separator">The string to use as a separator.</param>
        /// <param name="selector">Provides functionality to handle each member of the <paramref name="source"/> before conversation to string.</param>
        /// <returns>A string that consists of the members of <paramref name="source"/> delimited by the <paramref name="separator"/> string. If <paramref name="source"/> has no members, the method returns <see cref="System.String.Empty"/>.</returns>
        public static string JoinString<T>(this IEnumerable<T> source, string separator, Func<T, object> selector)
        {
            source.ValidateNull(nameof(source));
            separator.ValidateNull(nameof(separator));
            selector.ValidateNull(nameof(selector));

            return string.Join(separator, source.Select(selector));
        }
    }
}
