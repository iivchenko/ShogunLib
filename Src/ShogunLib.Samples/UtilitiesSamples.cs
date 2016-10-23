// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

namespace ShogunLib.Samples
{
    [TestFixture]
    public sealed class UtilitiesSamples
    {
        [Test]
        public void Sample()
        {
            Console.WriteLine(123.AsString());
            Console.WriteLine(123.AsString("Hello"));

            var value = new Tuple<string, int>("Hello", 1);
            var template = "[{0} {1}]";

            Console.WriteLine(value.AsString(template, x => x.Item1, x => x.Item2));
            Console.WriteLine(value.AsString(x => string.Format(CultureInfo.InvariantCulture, template, x.Item1, x.Item2)));

            var list = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine(list.JoinString(", "));
            Console.WriteLine(list.JoinString(", ", i => i + 1));
        }
        // Sample output
        // 123
        // Hello
        // [Hello 1]
        // [Hello 1]
        // 1, 2, 3, 4, 5
        // 2, 3, 4, 5, 6
    }
}