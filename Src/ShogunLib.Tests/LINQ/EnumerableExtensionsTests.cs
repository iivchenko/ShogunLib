// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;
using NUnit.Framework;
using ShogunLib.LINQ;

namespace ShogunLib.Tests.LINQ
{
    [TestFixture]
    public class EnumerableExtensionsTests
    {
        [Test]
        public void ForEach_SourceIsNull_Throws()
        {
            IEnumerable<int> source = null;

            Assert.Throws<ArgumentNullException>(() => source.ForEach(x => { x++; }));
        }

        [Test]
        public void ForEach_ActionIsNull_Throws()
        {
            IEnumerable<int> source = new List<int> { 1, 2, 3 };

            Assert.Throws<ArgumentNullException>(() => source.ForEach((Action<int>)null));
        }

        [Test]
        public void ForEach_Test()
        {
            const int expecteSum = 15;

            var sum = 0;
            IEnumerable<int> source = new List<int> { 1, 2, 3, 4, 5 };

            source.ForEach(x => sum += x);

            Assert.AreEqual(expecteSum, sum);
        }
    }
}
