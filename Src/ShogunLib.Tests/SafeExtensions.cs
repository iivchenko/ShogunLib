// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;

namespace ShogunLib.Tests
{
    public static class SafeExtensions
    {
        public static Safe AddExceptionHandler<TException>(this Safe source, Action<TException> handler)
            where TException : Exception
        {
            source.Exceptions[typeof (TException)].Add(handler);

            return source;
        }

        public static void Execute(this Safe source, Action action)
        {
            source.Execute(action);
        }
    }
}