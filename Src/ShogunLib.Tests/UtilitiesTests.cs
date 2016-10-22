// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using NUnit.Framework;

namespace ShogunLib.Tests
{
    [TestFixture]
    public class UtilitiesTests
    {
        [Test]
        public void AsString_NoInput()
        {
            var value = 1;

            Assert.AreEqual(value.ToString(), value.AsString());
        }

        [Test]
        public void AsString_WithTemplate()
        {
            var value = 1;
            var template = "Hello";

            Assert.AreEqual(template, value.AsString(template));
        }

        [Test]
        public void AsString_WithTemplateAndSelector()
        {
            var value = new Tuple<string, int>("Hello", 1);
            var template = "[{0} {1}]";

            var expected = string.Format(CultureInfo.InvariantCulture, template, value.Item1, value.Item2);
            var actual = value.AsString(template, x => x.Item1, x => x.Item2);
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AsString_WithTransformer()
        {
            var value = new Tuple<string, int>("Hello", 1);
            var template = "[{0} {1}]";

            var expected = string.Format(CultureInfo.InvariantCulture, template, value.Item1, value.Item2);
            var actual = value.AsString(x => string.Format(CultureInfo.InvariantCulture, template, x.Item1, x.Item2));

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void JoinString_NoSelector()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var expected = string.Join(", ", list);
            var actual = list.JoinString(", ");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void JoinString_WithSelector()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var expected = string.Join(", ", list.Select(i => i + 1));
            var actual = list.JoinString(", ", i => i + 1);

            Assert.AreEqual(expected, actual);
        }
    }
}
