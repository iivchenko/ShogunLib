// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;

namespace ShogunLib.Events
{
    /// <summary>
    /// Container for <see cref="EventExtensions.Raise{TEventArgs,TValue}"/>.
    /// </summary>
    /// <typeparam name="T">User defined event type.</typeparam>
    public class SimpleEventArgs<T> : EventArgs
    {
        /// <summary>
        /// Gets or sets user provided data.
        /// </summary>
        public T Value { get; set; }
    }
} 
