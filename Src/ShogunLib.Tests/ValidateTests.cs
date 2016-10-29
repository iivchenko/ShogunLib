// <copyright company="XATA">
//      Copyright (c) 2015, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using NUnit.Framework;

namespace ShogunLib.Tests
{
    [TestFixture]
    public class ValidateTests
    {
        [Test]
        public void Null_ParameterIsNotNull_DoNothing()
        {
            var parameter = new object();

            parameter.ValidateNull(nameof(parameter));
        }

        [Test]
        public void Null_ParameterIsNull_Throws()
        {
            var parameter = (object)null;

            Assert.Throws<ArgumentNullException>(() => parameter.ValidateNull(nameof(parameter)));
        }

        [Test]
        public void Null_NameNotSpecified_Throws()
        {
            var parameter = new object();

            Assert.Throws<ArgumentNullException>(() => parameter.ValidateNull(null));
        }

        [Test]
        public void StringEmpty_StringIsNotEmpty_DoNothing()
        {
            var parameter = "Hello world";

            parameter.ValidateStringEmpty(nameof(parameter));
        }

        [Test]
        public void StringEmpty_StringIsNull_Throws()
        {
            string parameter = null;

            Assert.Throws<ArgumentNullException>(() => parameter.ValidateStringEmpty(nameof(parameter)));
        }

        [TestCase("")]
        [TestCase("   ")]
        public void StringEmpty_StringIsEmpty_Throws(string input)
        {
            Assert.Throws<ArgumentException>(() => input.ValidateStringEmpty(nameof(input)));
        }

        [Test]
        public void StringEmpty_NameNotSpecified_Throws()
        {
            var parameter = "Hello world";
            
            Assert.Throws<ArgumentNullException>(() => parameter.ValidateStringEmpty(null));
        }
    }
}