// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using ShogunLib.LINQ;

namespace ShogunLib.Samples
{
    [TestFixture(Category = Constants.Category)]
    public sealed class CollectionExtensionsSamples
    {
        [Test]
        public void Sample()
        {
            var collection = new Collection<int> { 1, 2 };
            var list = new List<int> { 3, 4, 5 };

            collection.ForEach(x => Console.Write("{0} ", x));

            Console.WriteLine();

            collection.AddRange(list);

            collection.ForEach(x => Console.Write("{0} ", x));
        }
        // Sample output
        // 1 2 
        // 1 2 3 4 5 
    }
}
