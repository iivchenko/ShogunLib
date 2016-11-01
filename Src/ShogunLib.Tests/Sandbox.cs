// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using NUnit.Framework;

namespace ShogunLib.Tests
{
    [TestFixture]
    public sealed class Sandbox
    {
        [Test]
        public void Test()
        {
            //new Action<string>(name => { Console.WriteLine("HI");})
            //    .ToSave()
            //    .AddExceptionHandler<ArgumentNullException>(e => Console.WriteLine(e)))
            //    .SetExceptionPolicy(All)
            //    .Execute("My");

            Safe
                .CreateNew()
                .AddExceptionHandler<ArgumentNullException>(e => Console.WriteLine(e))
                .AddExceptionHandler<ArgumentNullException>(e => Console.WriteLine(e))
                .Execute(() => Console.WriteLine("Error prone code!!"));
        }
    }
}
