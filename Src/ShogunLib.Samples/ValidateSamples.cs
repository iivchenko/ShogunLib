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
    public sealed class ValidateSamples
    {
        [TestCase(null, null, null, "", 0)]
        public void Validate(
            object arg1,
            Action arg2,
            string arg3,
            string arg4,
            int arg5)
        {
            arg1.ValidateNull(nameof(arg1));
            arg2.ValidateNull(nameof(arg2));
            arg3.ValidateNull(nameof(arg3));

            arg4.ValidateStringEmpty(nameof(arg4));

            // arg5 can't be validated because it is not a ref type.
        }
    }
}
