// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using NUnit.Framework;
using ShogunLib.Monads;

namespace ShogunLib.Tests.Monads
{
    [TestFixture]
    public class MaybeExtensionsTests
    {
        private const string TestValue = "LOL";

        [TestCase(TestValue, true)]
        [TestCase((string)null, false)]
        public void ToMaybe_Test(string expectedValue, bool hasValue)
        {
            var maybe = expectedValue.ToMaybe();

            Assert.AreEqual(hasValue, maybe.HasValue);
            Assert.AreEqual(expectedValue, maybe.Value);
        }

        [TestCase(TestValue)]
        [TestCase((string)null)]
        public void Return_Test(string input)
        {
            var actual = new Maybe<string>(input).Return();

            Assert.AreEqual(input, actual);
        }

        [TestCase(TestValue, true)]
        [TestCase((string)null, false)]
        public void Bind_Test(string input, bool expectedActionResult)
        {
            var maybe = new Maybe<string>(input);
            var actualActionResult =
                maybe
                    .Bind(x => true)
                    .Value;

            Assert.AreEqual(expectedActionResult, actualActionResult);
        }

        [TestCase(TestValue, true)]
        [TestCase((string)null, false)]
        public void Do_Void_Test(string input, bool expectedActionResult)
        {
            var maybe = new Maybe<string>(input);
            var actualActionResult = false;

            maybe
                .Do(x => actualActionResult = true);

            Assert.AreEqual(expectedActionResult, actualActionResult);
        }

        [TestCase(TestValue, true, TestValue)]
        [TestCase((string)null, false, null)]
        public void Do_Result_Test(string input, bool expectedActionResult, string expectedReturnResult)
        {
            var maybe = new Maybe<string>(input);
            var actualActionResult = false;

            var returnResult =
                maybe
                    .Do(x =>
                    {
                        actualActionResult = true;
                        return TestValue;
                    });

            Assert.AreEqual(expectedActionResult, actualActionResult);
            Assert.AreEqual(expectedReturnResult, returnResult);
        }
    }
}