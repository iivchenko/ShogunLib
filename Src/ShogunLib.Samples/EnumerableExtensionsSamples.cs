// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;
using NUnit.Framework;
using ShogunLib.LINQ;

namespace ShogunLib.Samples
{
    [TestFixture]
    public sealed class EnumerableExtensionsSamples
    {
        [Test]
        public void Sample()
        {
            IEnumerable<int> list = new List<int> { 1, 2, 3, 4, 5 };
            IEnumerable<int> newList = new List<int>();

            newList = list.ForEach(x => ++x);

            list.ForEach(x => Console.Write("{0} ", x));

            Console.WriteLine();

            newList.ForEach(x => Console.Write("{0} ", x));
        }
        // Sample output
        // 1 2 3 4 5
        // 2 3 4 5 6
    }
}
