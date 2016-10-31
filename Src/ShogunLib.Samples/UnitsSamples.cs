// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using NUnit.Framework;

namespace ShogunLib.Samples
{
    [TestFixture(Category = Constants.Category)]
    public sealed class UnitsSamples
    {
        [Test]
        public void Sample_1()
        {
            var template = "{0:F2} {1}";
            Func<Unit, object> name = unit => unit.Name;
            Func<Unit, object> value = unit => unit.Value;

            long i0 = 0;             // 0 bytes
            long i1 = 1;             // 1 byte
            long i2 = 1023;          // 1023 bytes
            long i3 = 1024;          // 1 KB
            long i4 = 2560;          // 2.5 KB
            long i5 = 1048576;       // 1 MB
            long i6 = 720371127;     // 686.9994421005249 MB
            long i7 = 1073741824;    // 1 GB
            long i8 = 1099511627776; // 1 TB

            Console.WriteLine(i0.ToUnit().AsString(template, value, name));
            Console.WriteLine(i1.ToUnit().AsString(template, value, name));
            Console.WriteLine(i2.ToUnit().AsString(template, value, name));
            Console.WriteLine(i3.ToUnit().AsString(template, value, name));
            Console.WriteLine(i4.ToUnit().AsString(template, value, name));
            Console.WriteLine(i5.ToUnit().AsString(template, value, name));
            Console.WriteLine(i6.ToUnit().AsString(template, value, name));
            Console.WriteLine(i7.ToUnit().AsString(template, value, name));
            Console.WriteLine(i8.ToUnit().AsString(template, value, name));
        }
        // Sample_1 output
        // 0.00 Byte
        // 1.00 Byte
        // 1023.00 Byte
        // 1.00 KB
        // 2.50 KB
        // 1.00 MB
        // 687.00 MB
        // 1.00 GB
        // 1.00 TB

        [Test]
        public void Sample_2()
        {
            var template = "{0:F2} {1}";
            Func<Unit, object> name = unit => unit.Name;
            Func<Unit, object> value = unit => unit.Value;

            long i0 = 0;             // 0 bytes
            long i1 = 1;             // 1 byte
            long i2 = 1023;          // 1023 bytes
            long i3 = 1024;          // 1024 bytes 
            long i4 = 2560;          // 2560 bytes
            long i5 = 1048576;       // 1024 KB
            long i6 = 720371127;     // 686.9994421005249 MB
            long i7 = 1073741824;    // 0.0009765625 TB
            long i8 = 1099511627776; // 1 TB

            Console.WriteLine(i0.ToUnit(UnitType.Byte).AsString(template, value, name));
            Console.WriteLine(i1.ToUnit(UnitType.Byte).AsString(template, value, name));
            Console.WriteLine(i2.ToUnit(UnitType.Byte).AsString(template, value, name));
            Console.WriteLine(i3.ToUnit(UnitType.Byte).AsString(template, value, name));
            Console.WriteLine(i4.ToUnit(UnitType.Byte).AsString(template, value, name));
            Console.WriteLine(i5.ToUnit(UnitType.KB).AsString(template, value, name));
            Console.WriteLine(i6.ToUnit(UnitType.MB).AsString(template, value, name));
            Console.WriteLine(i7.ToUnit(UnitType.TB).AsString(template, value, name));
            Console.WriteLine(i8.ToUnit(UnitType.TB).AsString(template, value, name));
        }
        // Sample_2 output
        // 0.00 Byte
        // 1.00 Byte
        // 1023.00 Byte
        // 1024.00 Byte
        // 2560.00 Byte
        // 1024.00 KB
        // 687.00 MB
        // 0.00 TB
        // 1.00 TB
    }
}