// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

namespace ShogunLib.Monads
{
    /// <summary>
    /// Container for Maybe monad.
    /// </summary>
    /// <typeparam name="T">The type which is wrapped by the Maybe monad.</typeparam>
    public class Maybe<T>
    {
        internal Maybe(T value)
        {
            Value = value;
            HasValue = value != null;
        }

        /// <summary>
        /// Gets wrapped value.
        /// </summary>
        internal T Value { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the <see cref="Value"/> is present or not.
        /// </summary>
        internal bool HasValue { get; private set; }
    }
}