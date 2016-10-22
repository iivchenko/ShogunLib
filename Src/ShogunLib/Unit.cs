// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

namespace ShogunLib
{
    /// <summary>
    /// Provides information about amount of data capacity and specific type of data capacity in Byte or KB or MB or GB etc.
    /// </summary>
    public sealed class Unit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Unit"/> class.
        /// </summary>
        internal Unit(UnitType name, double value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Gets the type of data capacity like Byte, KB, MB, GB etc.
        /// </summary>
        public UnitType Name { get; private set; }

        /// <summary>
        /// Gets the amount of data capacity.
        /// </summary>
        public double Value { get; private set; }

        /// <summary>
        /// Determines whether two object instances are equal.
        /// </summary>
        public static bool operator ==(Unit left, Unit right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (((object)left == null) || ((object)right == null))
            {
                return false;
            }

            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two object instances are not equal.
        /// </summary>
        public static bool operator !=(Unit left, Unit right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Determines whether two object instances are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            return Equals(obj as Unit);
        }

        /// <summary>
        /// Determines whether two object instances are equal.
        /// </summary>
        public bool Equals(Unit unit)
        {
            if ((object)unit == null)
            {
                return false;
            }

            return Name == unit.Name && Value.Equals(unit.Value);
        }

        /// <summary>
        /// Just a hash function.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((int)Name * 397) ^ Value.GetHashCode();
            }
        }
    }
}
