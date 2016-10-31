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

namespace ShogunLib.Tests.LINQ
{
    [TestFixture]
    public sealed class CollectionExtensionsTests
    {
        [Test]
        public void AddRange_SourceIsNull_Throws()
        {
            ICollection<int> source = null;
            var values = new List<int> { 1, 2, 3 };

            Assert.Throws<ArgumentNullException>(() => source.AddRange(values));
        }

        [Test]
        public void AddRange_ValuesIsNull_Throws()
        {
            var source = new Collection<int>();
            IEnumerable<int> values = null;

            Assert.Throws<ArgumentNullException>(() => source.AddRange(values));
        }

        [Test]
        public void AddRange_Test()
        {
            const int ExpectedCount = 3;

            var source = new Collection<int>();
            var values = new List<int> { 1, 2, 3 };

            source.AddRange(values);

            Assert.AreEqual(ExpectedCount, source.Count);
        }
    }
}
