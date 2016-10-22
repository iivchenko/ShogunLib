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

namespace ShogunLib.Tests.LINQ
{
    [TestFixture]
    public class EnumerableExtensionsTests
    {
        [Test]
        public void ForEach_WithoutResult_SourceIsNull_Throws()
        {
            IEnumerable<int> source = null;

            Assert.Throws<ArgumentNullException>(() => source.ForEach(x => { x++; }));
        }

        [Test]
        public void ForEach_WithResult_SourceIsNull_Throws()
        {
            IEnumerable<int> source = null;

            Assert.Throws<ArgumentNullException>(() => source.ForEach(x => { return x; }));
        }

        [Test]
        public void ForEach_WithoutResult_ActionIsNull_Throws()
        {
            IEnumerable<int> source = new List<int>();

            Assert.Throws<ArgumentNullException>(() => source.ForEach((Action<int>)null));
        }

        [Test]
        public void ForEach_WithResult_FuncIsNull_Throws()
        {
            IEnumerable<int> source = new List<int>();

            Assert.Throws<ArgumentNullException>(() => source.ForEach((Func<int, int>)null));
        }

        [Test]
        public void ForEach_WithoutResult_Test()
        {
            var counter = 1;
            IEnumerable<int> source = new List<int> { 1, 2, 3, 4, 5 };

            source.ForEach(x => Assert.AreEqual(counter++, x));
        }

        [Test]
        public void ForEach_WithResult_Test()
        {
            IEnumerable<int> source = new List<int> { 1, 2, 3, 4, 5 };

            var actual = source.ForEach(x => ++x);

            for (var i = 0; i < actual.Count(); i++)
            {
                Assert.AreEqual(source.ElementAt(i) + 1, actual.ElementAt(i));
            }
        }
    }
}
