// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>


namespace ShogunLib.Tests
{
    public class Safe
    {
        private Safe()
        {
        }

        public static Safe CreateNew()
        {
            return new Safe();
        }
    }
}