// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ShogunLib
{
    /// <summary>
    /// Extensions methods which helps with data capacity conversation.
    /// </summary>
    public static class Units
    {
        /// <summary>
        /// Converts input amount of bytes into more convenient and readable data capacity type.
        /// </summary>
        /// <param name="value">Amount of bytes to convert.</param>
        /// <returns>More readable data capacity type.</returns>
        public static Unit ToUnit(this long value)
        {
            ValidateLessThanZero(value);

            var workValue = (double)value;
            var units = Enum.GetValues(typeof(UnitType));
            var workUnit = (UnitType)units.GetValue(0);

            foreach (UnitType unit in units)
            {
                workUnit = unit;

                if (workValue > 1023)
                {
                    workValue /= 1024;
                }
                else
                {
                    break;
                }
            }

            return new Unit(workUnit, workValue);
        }

        /// <summary>
        /// Converts input amount of bytes into more specific data capacity type.
        /// </summary>
        /// <param name="value">Amount of bytes to convert.</param>
        /// <param name="unit">Specific data capacity type.</param>
        /// <returns>Converted amount of bytes.</returns>
        public static Unit ToUnit(this long value, UnitType unit)
        {
            ValidateLessThanZero(value);

            var workValue = (double)value;
            var units = Enum.GetValues(typeof(UnitType));

            foreach (UnitType workUnit in units)
            {
                if (workUnit == unit)
                {
                    break;
                }
                
                workValue /= 1024;
            }

            return new Unit(unit, workValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ValidateLessThanZero(long value)
        {
            if (value < 0)
            {
                var msg =
                    string.Format(
                        CultureInfo.InvariantCulture,
                        "Can't convert input value ({0}). The value should not be less that zero.",
                        value);

                throw new ArithmeticException(msg);
            }
        }
    }
}
