// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using NUnit.Framework;

namespace ShogunLib.Tests
{
    [TestFixture]
    public class UnitsTests
    {
        [Test]
        public void ToUnit_NoInputType_InputLessThanZero_Throws()
        {
            long input = -1;

            Assert.Throws<ArithmeticException>(() => input.ToUnit());
        }

        [Test]
        public void ToUnit_WithUnitType_InputLessThanZero_Throws()
        {
            long input = -1;

            Assert.Throws<ArithmeticException>(() => input.ToUnit(UnitType.GB));
        }

        [TestCase(0, UnitType.Byte, 0.0)]
        [TestCase(1, UnitType.Byte, 1.0)]
        [TestCase(1023, UnitType.Byte, 1023.0)]
        [TestCase(1024, UnitType.KB, 1.0)]
        [TestCase(2560, UnitType.KB, 2.5)]
        [TestCase(1048576, UnitType.MB, 1.0)]
        [TestCase(720371127, UnitType.MB, 686.9994421005249)]
        [TestCase(1073741824, UnitType.GB, 1.0)]
        [TestCase(1099511627776, UnitType.TB, 1.0)]
        public void ToUnit_NoInputType_AlgorithmTest(long input, UnitType expectedType, double expectedValue)
        {
            var actual = input.ToUnit();
            var expected = new Unit(expectedType, expectedValue);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, UnitType.Byte, 0.0)]
        [TestCase(1, UnitType.Byte, 1.0)]
        [TestCase(1023, UnitType.Byte, 1023.0)]
        [TestCase(1024, UnitType.Byte, 1024.0)]
        [TestCase(2560, UnitType.Byte, 2560.0)]
        [TestCase(1048576, UnitType.KB, 1024.0)]
        [TestCase(720371127, UnitType.MB, 686.9994421005249)]
        [TestCase(1073741824, UnitType.TB, 0.0009765625)]
        [TestCase(1099511627776, UnitType.TB, 1.0)]
        public void ToUnit_WithInputType_AlgorithmTest(long input, UnitType type, double expectedValue)
        {
            var actual = input.ToUnit(type);
            var expected = new Unit(type, expectedValue);

            Assert.AreEqual(expected, actual);
        }
    }
}
