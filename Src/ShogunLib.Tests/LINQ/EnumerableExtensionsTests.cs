// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            const int ExpecteSum = 15;

            var sum = 0;
            IEnumerable<int> source = new List<int> { 1, 2, 3, 4, 5 };

            source.ForEach(x => sum += x);

            Assert.AreEqual(ExpecteSum, sum);
        }

        [Test]
        public void Apply_SourceIsNull_Throws()
        {
            IEnumerable<int> source = null;

            Assert.Throws<ArgumentNullException>(() => source.Apply(x => { x++; }).ToList());
        }

        [Test]
        public void Apply_ActionIsNull_Throws()
        {
            IEnumerable<int> source = new List<int> { 1, 2, 3 };

            Assert.Throws<ArgumentNullException>(() => source.Apply((Action<int>)null).ToList());
        }

        [Test]
        public void Apply_ReturnNewSequence_InputAndOutputSequencesSame()
        {
            var source = new List<Item> { new Item(1), new Item(2), new Item(3) };

            var source2 =
                source
                    .Apply(x => x.Value++)
                    .ToList();

            CollectionAssert.AreEqual(source, source2);
        }

        [Test]
        public void Apply_ApplyAction_ActionApplied()
        {
            const int ExpecteDiff = 3;

            var source = new List<Item> { new Item(1), new Item(2), new Item(3) };
            var sum1 = 0;
            var sum2 = 0;

            source
                .Apply(x => sum1 += x.Value)
                .Apply(x => x.Value++)
                .Apply(x => sum2 += x.Value)
                .ToList();

            Assert.AreEqual(ExpecteDiff, sum2 - sum1);
        }

        private class Item
        {
            public Item(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
        }
    }
}
