// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ShogunLib.LINQ;

namespace ShogunLib.Samples
{
    [TestFixture(Category = Constants.Category)]
    public sealed class EnumerableExtensionsSamples
    {
        private class Item
        {
            public Item(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
        }

        [Test]
        public void Sample_1()
        {
            IEnumerable<int> list = new List<int> { 1, 2, 3, 4, 5 };
           
            list.ForEach(x => Console.Write("{0} ", x));

            Console.WriteLine();
        }
        // Sample output
        // 1 2 3 4 5

        [Test]
        public void Sample_2()
        {
            var source = new List<int> { 1, 2, 3 };

            var originalSource =
                source
                    .Apply(x => Console.Write($"<{x}> "))
                    .Apply(x => Console.Write($"[{x}] "))
                    .ToList();

            Console.WriteLine();

            originalSource.ForEach(x => Console.Write($"{x} "));
        }
        // Sample output
        // <1> [1] <2> [2] <3> [3] 
        // 1 2 3 
    }
}
