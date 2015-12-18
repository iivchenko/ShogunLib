// <copyright company="XATA">
//      Copyright (c) 2016, by Shogun All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;

namespace ShogunLib
{
    /// <summary>
    /// Provides extension methods for parameters/arguments validation.
    /// </summary>
    public static class Validate
    {
        /// <summary>
        /// Throws if <paramref name="input"/> is Null.
        /// </summary>
        /// <typeparam name="T">Type of the <paramref name="input"/> object.</typeparam>
        /// <param name="input">Object that is under validation.</param>
        /// <param name="parameterName">Name of the <paramref name="input"/> variable/parameter. Can't be NULL.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="input"/> or <paramref name="parameterName"/> is NULL</exception>
        public static void ValidateNull<T>(this T input, string parameterName) 
            where T : class 
        {
            if (parameterName == null)
            {
                throw new ArgumentNullException("parameterName");
            }

            if (input == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }

        /// <summary>
        /// Throws if <paramref name="input"/> string is Null, Empty or Whitespaces.
        /// </summary>
        /// <param name="input">String that is under validation.</param>
        /// <param name="parameterName">Name of the <paramref name="input"/> variable/parameter. Can't be NULL.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="input"/> or <paramref name="parameterName"/> is NULL.</exception>
        /// <exception cref="ArgumentException">If <paramref name="input"/> is <see cref="string.Empty"/> or whitespaces.</exception>
        public static void ValidateStringEmpty(this string input, string parameterName)
        {
            ValidateNull(input, parameterName);

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("String parameter can't be empty or whitespaces.", parameterName);
            }
        }
    }
}