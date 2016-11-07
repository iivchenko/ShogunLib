// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using NUnit.Framework;
using ShogunLib.Monads;

namespace ShogunLib.Samples
{
    [TestFixture(Category = Constants.Category)]
    // To avoid dozens of null checks use Maybe =)
    public sealed class MaybeSamples
    {
        private class Class1
        {
            public string Value { get; set; }
        }

        private class Class2
        {
            public Class1 Value { get; set; }
        }

        private class Class3
        {
            public Class2 Value { get; set; }
        }

        private class Class4
        {
            public Class3 Value { get; set; }
        }

        private class Class5
        {
            public Class4 Value { get; set; }
        }

        [Test]
        public void Sample_1()
        {
            var _class = new Class5
            {
                Value = new Class4
                {
                    Value = new Class3
                    {
                        Value = new Class2
                        {
                            Value = new Class1
                            {
                                Value = "Bingo!"
                            }
                        }
                    }
                }
            };

            _class
                .ToMaybe()
                .Bind(x => x.Value)
                .Bind(x => x.Value)
                .Bind(x => x.Value)
                .Bind(x => x.Value)
                .Do(x => Console.WriteLine(x.Value));
        }
        // Sample_1 output 
        // Bingo!

        [Test]
        public void Sample_2()
        {
            var _class = new Class5
            {
                Value = new Class4
                {
                    Value = new Class3
                    {
                        Value = new Class2
                        {
                            Value = new Class1
                            {
                                Value = "Bingo!"
                            }
                        }
                    }
                }
            };

            var bingo =
                _class
                    .ToMaybe()
                    .Bind(x => x.Value)
                    .Bind(x => x.Value)
                    .Bind(x => x.Value)
                    .Bind(x => x.Value)
                    .Bind(x => x.Value)
                    .Return();

            Console.WriteLine(bingo);
        }
        // Sample_2 output
        // Bingo!

        [Test]
        public void Sample_3()
        {
            var _class1 = new Class5
            {
                Value = new Class4
                {
                    Value = new Class3
                    {
                        Value = null // no bingo :'(
                    }
                }
            };

            _class1
                .ToMaybe()
                .Bind(x => x.Value)
                .Bind(x => x.Value)
                .Bind(x => x.Value) // here is the NULL, so below code (including Console.WriteLine(x.Value)) will not run
                .Bind(x => x.Value)
                .Do(x => Console.WriteLine(x.Value));
        }
        // Sample_3 output
        //

        [Test]
        public void Sample_4()
        {
            var _class = new Class5
            {
                Value = new Class4
                {
                    Value = new Class3
                    {
                        Value = new Class2
                        {
                            Value = new Class1
                            {
                                Value = "Bingo!"
                            }
                        }
                    }
                }
            };

            var result =
                _class
                    .ToMaybe()
                    .Bind(x => x.Value)
                    .Bind(x => x.Value)
                    .Bind(x => x.Value)
                    .Bind(x => x.Value)
                    .Do(x => x.Value);

            Console.WriteLine(result);
        }
        // Sample_4 output
        // Bingo!

        [Test]
        public void Sample_5()
        {
            var _class1 = new Class5
            {
                Value = new Class4
                {
                    Value = new Class3
                    {
                        Value = null // no bingo :'(
                    }
                }
            };

            var result =
                _class1
                    .ToMaybe()
                    .Bind(x => x.Value)
                    .Bind(x => x.Value)
                    .Bind(x => x.Value) // here is the NULL, so below code will not run and result will be default(T)
                    .Bind(x => x.Value)
                    .Do(x => x.Value);

            Console.WriteLine(result);
        }
        // Sample_5 output
        // 
    }
}