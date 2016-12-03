// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using NUnit.Framework;
using ShogunLib.Patterns.ChainOfResponsibility;

namespace ShogunLib.Tests.Patterns.ChainOfResponsibility.Integration
{
    [TestFixture]
    public sealed class ChainTests
    {
        private const bool Do = true;
        private const bool Skip = false;

        private const int Parameter1 = 1;
        private const int Parameter2 = 2;
        private const int Parameter3 = 3;
        private const int Parameter4 = 4;
        private const int Parameter5 = 5;
        private const string Result = "Hello";

        public enum WhichLink
        {
            None,
            First,
            Second,
            Third
        }

        #region Void chain tests

        #region No parameters

        [Test]
        public void VoidChain_NoParameters_NoLinks_DoNothing()
        {
            ChainFactory
                .CreateVoidBuilder()
                .Build()
                .Execute();
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void VoidChain_NoParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = WhichLink.None;

            ChainFactory
                .CreateVoidBuilder()
                .Add(() => canFirst, () => link = WhichLink.First)
                .Add(() => canSecond, () => link = WhichLink.Second)
                .Add(() => canThird, () => link = WhichLink.Third)
                .Build()
                .Execute();

            Assert.AreEqual(expectedLink, link);
        }

        #endregion

        #region One parameter

        [Test]
        public void VoidChain_OneParameters_NoLinks_DoNothing()
        {
            ChainFactory
                .CreateVoidBuilder<int>()
                .Build()
                .Execute(1);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void VoidChain_OneParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = WhichLink.None;

            ChainFactory
                .CreateVoidBuilder<int>()
                .Add(t1 => canFirst, t1 => link = WhichLink.First)
                .Add(t1 => canSecond, t1 => link = WhichLink.Second)
                .Add(t1 => canThird, t1 => link = WhichLink.Third)
                .Build()
                .Execute(1);

            Assert.AreEqual(expectedLink, link);
        }

        [Test]
        public void VoidChain_OneParameters_ParametersUsed()
        {
            ChainFactory
                .CreateVoidBuilder<int>()
                .Add(
                    t1 =>
                    {
                        Assert.AreEqual(Parameter1, t1);
                        return true;
                    },
                    t1 =>
                    {
                        Assert.AreEqual(Parameter1, t1);
                    })
                .Build()
                .Execute(Parameter1);
        }
        
        #endregion

        #region Two parameters

        [Test]
        public void VoidChain_TwoParameters_NoLinks_DoNothing()
        {
            ChainFactory
                .CreateVoidBuilder<int, int>()
                .Build()
                .Execute(1, 2);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void VoidChain_TwoParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = WhichLink.None;

            ChainFactory
                .CreateVoidBuilder<int, int>()
                .Add((t1, t2) => canFirst, (t1, t2) => link = WhichLink.First)
                .Add((t1, t2) => canSecond, (t1, t2) => link = WhichLink.Second)
                .Add((t1, t2) => canThird, (t1, t2) => link = WhichLink.Third)
                .Build()
                .Execute(1, 2);

            Assert.AreEqual(expectedLink, link);
        }

        [Test]
        public void VoidChain_TwoParameters_ParametersUsed()
        {
            ChainFactory
                .CreateVoidBuilder<int, int>()
                .Add(
                    (t1, t2) =>
                    {
                        Assert.AreEqual(Parameter1, t1);
                        Assert.AreEqual(Parameter2, t2);
                        return true;
                    },
                    (t1, t2) =>
                    {
                        Assert.AreEqual(Parameter1, t1);
                        Assert.AreEqual(Parameter2, t2);
                    })
                .Build()
                .Execute(Parameter1, Parameter2);
        }

        #endregion

        #region Three parameters

        [Test]
        public void VoidChain_ThreeParameters_NoLinks_DoNothing()
        {
            ChainFactory
                .CreateVoidBuilder<int, int, int>()
                .Build()
                .Execute(1, 2, 3);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void VoidChain_ThreeParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = WhichLink.None;

            ChainFactory
                .CreateVoidBuilder<int, int, int>()
                .Add((t1, t2, t3) => canFirst, (t1, t2, t3) => link = WhichLink.First)
                .Add((t1, t2, t3) => canSecond, (t1, t2, t3) => link = WhichLink.Second)
                .Add((t1, t2, t3) => canThird, (t1, t2, t3) => link = WhichLink.Third)
                .Build()
                .Execute(1, 2, 3);

            Assert.AreEqual(expectedLink, link);
        }

        [Test]
        public void VoidChain_ThreeParameters_ParametersUsed()
        {
            ChainFactory
                .CreateVoidBuilder<int, int, int>()
                .Add(
                    (t1, t2, t3) =>
                    {
                        Assert.AreEqual(Parameter1, t1);
                        Assert.AreEqual(Parameter2, t2);
                        Assert.AreEqual(Parameter3, t3);
                        return true;
                    },
                    (t1, t2, t3) =>
                    {
                        Assert.AreEqual(Parameter1, t1);
                        Assert.AreEqual(Parameter2, t2);
                        Assert.AreEqual(Parameter3, t3);
                    })
                .Build()
                .Execute(Parameter1, Parameter2, Parameter3);
        }

        #endregion

        #region Four parameters

        [Test]
        public void VoidChain_FourParameters_NoLinks_DoNothing()
        {
            ChainFactory
                .CreateVoidBuilder<int, int, int, int>()
                .Build()
                .Execute(1, 2, 3, 4);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void VoidChain_FourParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = WhichLink.None;

            ChainFactory
                .CreateVoidBuilder<int, int, int, int>()
                .Add((t1, t2, t3, t4) => canFirst, (t1, t2, t3, t4) => link = WhichLink.First)
                .Add((t1, t2, t3, t4) => canSecond, (t1, t2, t3, t4) => link = WhichLink.Second)
                .Add((t1, t2, t3, t4) => canThird, (t1, t2, t3, t4) => link = WhichLink.Third)
                .Build()
                .Execute(1, 2, 3, 4);

            Assert.AreEqual(expectedLink, link);
        }

        [Test]
        public void VoidChain_FourParameters_ParametersUsed()
        {
            ChainFactory
                .CreateVoidBuilder<int, int, int, int>()
                .Add(
                    (t1, t2, t3, t4) =>
                    {
                        Assert.AreEqual(Parameter1, t1);
                        Assert.AreEqual(Parameter2, t2);
                        Assert.AreEqual(Parameter3, t3);
                        Assert.AreEqual(Parameter4, t4);
                        return true;
                    },
                    (t1, t2, t3, t4) =>
                    {
                        Assert.AreEqual(Parameter1, t1);
                        Assert.AreEqual(Parameter2, t2);
                        Assert.AreEqual(Parameter3, t3);
                        Assert.AreEqual(Parameter4, t4);
                    })
                .Build()
                .Execute(Parameter1, Parameter2, Parameter3, Parameter4);
        }

        #endregion

        #region Five parameters

        [Test]
        public void VoidChain_FiveParameters_NoLinks_DoNothing()
        {
            ChainFactory
                .CreateVoidBuilder<int, int, int, int, int>()
                .Build()
                .Execute(1, 2, 3, 4, 5);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void VoidChain_FiveParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = WhichLink.None;

            ChainFactory
                .CreateVoidBuilder<int, int, int, int, int>()
                .Add((t1, t2, t3, t4, t5) => canFirst, (t1, t2, t3, t4, t5) => link = WhichLink.First)
                .Add((t1, t2, t3, t4, t5) => canSecond, (t1, t2, t3, t4, t5) => link = WhichLink.Second)
                .Add((t1, t2, t3, t4, t5) => canThird, (t1, t2, t3, t4, t5) => link = WhichLink.Third)
                .Build()
                .Execute(1, 2, 3, 4, 5);

            Assert.AreEqual(expectedLink, link);
        }

        [Test]
        public void VoidChain_FiveParameters_ParametersUsed()
        {
            ChainFactory
                .CreateVoidBuilder<int, int, int, int, int>()
                .Add(
                    (t1, t2, t3, t4, t5) =>
                    {
                        Assert.AreEqual(Parameter1, t1);
                        Assert.AreEqual(Parameter2, t2);
                        Assert.AreEqual(Parameter3, t3);
                        Assert.AreEqual(Parameter4, t4);
                        Assert.AreEqual(Parameter5, t5);
                        return true;
                    },
                    (t1, t2, t3, t4, t5) =>
                    {
                        Assert.AreEqual(Parameter1, t1);
                        Assert.AreEqual(Parameter2, t2);
                        Assert.AreEqual(Parameter3, t3);
                        Assert.AreEqual(Parameter4, t4);
                        Assert.AreEqual(Parameter5, t5);
                    })
                .Build()
                .Execute(Parameter1, Parameter2, Parameter3, Parameter4, Parameter5);
        }

        #endregion

        #endregion

        #region Result chain tests

        #region No parameters

        [Test]
        public void ResultChain_NoParameters_NoLinks_DoNothing()
        {
            var result =
                ChainFactory
                    .CreateResultBuilder<string>()
                    .Build()
                    .Execute();

            Assert.AreEqual(default(string), result);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void ResultChain_NoParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = ChainFactory
                .CreateResultBuilder<WhichLink>()
                .Add(() => canFirst, () => WhichLink.First)
                .Add(() => canSecond, () => WhichLink.Second)
                .Add(() => canThird, () => WhichLink.Third)
                .Build()
                .Execute();

            Assert.AreEqual(expectedLink, link);
        }
      
        #endregion

        #region One parameter

        [Test]
        public void ResultChain_OneParameters_NoLinks_DoNothing()
        {
            var result =
                ChainFactory
                    .CreateResultBuilder<int, string>()
                    .Build()
                    .Execute(1);

            Assert.AreEqual(default(string), result);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void ResultChain_OneParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = ChainFactory
                .CreateResultBuilder<int, WhichLink>()
                .Add(t1 => canFirst, t1 => WhichLink.First)
                .Add(t1 => canSecond, t1 => WhichLink.Second)
                .Add(t1 => canThird, t1 => WhichLink.Third)
                .Build()
                .Execute(1);

            Assert.AreEqual(expectedLink, link);
        }

        [Test]
        public void ResultChain_OneParameters_ParametersUsed()
        {
            var result =
                ChainFactory
                    .CreateResultBuilder<int, string>()
                    .Add(
                        t1 =>
                        {
                            Assert.AreEqual(Parameter1, t1);
                            return true;
                        },
                        t1 =>
                        {
                            Assert.AreEqual(Parameter1, t1);
                            return Result;
                        })
                    .Build()
                    .Execute(Parameter1);

            Assert.AreEqual(Result, result);
        }

        [Test]
        public void ResultChain_OneParameters_WithLinks_FistLinkDo()
        {
        }

        [Test]
        public void ResultChain_OneParameters_WithLinks_SecondLinkDo()
        {
        }

        [Test]
        public void ResultChain_OneParameters_WithLinks_LastLinkDo()
        {
        }

        [Test]
        public void ResultChain_OneParameters_WithLinks_DoNothing()
        {
        }

        #endregion

        #region Two parameters

        [Test]
        public void ResultChain_TwoParameters_NoLinks_DoNothing()
        {
            var result =
                ChainFactory
                    .CreateResultBuilder<int, int, string>()
                    .Build()
                    .Execute(1, 2);

            Assert.AreEqual(default(string), result);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void ResultChain_TwoParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = ChainFactory
                .CreateResultBuilder<int, int, WhichLink>()
                .Add((t1, t2) => canFirst, (t1, t2) => WhichLink.First)
                .Add((t1, t2) => canSecond, (t1, t2) => WhichLink.Second)
                .Add((t1, t2) => canThird, (t1, t2) => WhichLink.Third)
                .Build()
                .Execute(1, 2);

            Assert.AreEqual(expectedLink, link);
        }

        [Test]
        public void ResultChain_TwoParameters_ParametersUsed()
        {
            var result =
                ChainFactory
                    .CreateResultBuilder<int, int, string>()
                    .Add(
                        (t1, t2) =>
                        {
                            Assert.AreEqual(Parameter1, t1);
                            Assert.AreEqual(Parameter2, t2);
                            return true;
                        },
                        (t1, t2) =>
                        {
                            Assert.AreEqual(Parameter1, t1);
                            Assert.AreEqual(Parameter2, t2);
                            return Result;
                        })
                    .Build()
                    .Execute(Parameter1, Parameter2);

            Assert.AreEqual(Result, result);
        }

        #endregion

        #region Three parameters

        [Test]
        public void ResultChain_ThreeParameters_NoLinks_DoNothing()
        {
            var result =
                ChainFactory
                    .CreateResultBuilder<int, int, int, string>()
                    .Build()
                    .Execute(1, 2, 3);

            Assert.AreEqual(default(string), result);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void ResultChain_ThreeParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = ChainFactory
                .CreateResultBuilder<int, int, int, WhichLink>()
                .Add((t1, t2, t3) => canFirst, (t1, t2, t3) => WhichLink.First)
                .Add((t1, t2, t3) => canSecond, (t1, t2, t3) => WhichLink.Second)
                .Add((t1, t2, t3) => canThird, (t1, t2, t3) => WhichLink.Third)
                .Build()
                .Execute(1, 2, 3);

            Assert.AreEqual(expectedLink, link);
        }

        [Test]
        public void ResultChain_ThreeParameters_ParametersUsed()
        {
            var result =
                ChainFactory
                    .CreateResultBuilder<int, int, int, string>()
                    .Add(
                        (t1, t2, t3) =>
                        {
                            Assert.AreEqual(Parameter1, t1);
                            Assert.AreEqual(Parameter2, t2);
                            Assert.AreEqual(Parameter3, t3);
                            return true;
                        },
                        (t1, t2, t3) =>
                        {
                            Assert.AreEqual(Parameter1, t1);
                            Assert.AreEqual(Parameter2, t2);
                            Assert.AreEqual(Parameter3, t3);
                            return Result;
                        })
                    .Build()
                    .Execute(Parameter1, Parameter2, Parameter3);

            Assert.AreEqual(Result, result);
        }

        #endregion

        #region Four parameters

        [Test]
        public void ResultChain_FourParameters_NoLinks_DoNothing()
        {
            var result =
                ChainFactory
                    .CreateResultBuilder<int, int, int, int, string>()
                    .Build()
                    .Execute(1, 2, 3, 4);

            Assert.AreEqual(default(string), result);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void ResultChain_FourParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = ChainFactory
                .CreateResultBuilder<int, int, int, int, WhichLink>()
                .Add((t1, t2, t3, t4) => canFirst, (t1, t2, t3, t4) => WhichLink.First)
                .Add((t1, t2, t3, t4) => canSecond, (t1, t2, t3, t4) => WhichLink.Second)
                .Add((t1, t2, t3, t4) => canThird, (t1, t2, t3, t4) => WhichLink.Third)
                .Build()
                .Execute(1, 2, 3, 4);

            Assert.AreEqual(expectedLink, link);
        }

        [Test]
        public void ResultChain_FourParameters_ParametersUsed()
        {
            var result =
                ChainFactory
                    .CreateResultBuilder<int, int, int, int, string>()
                    .Add(
                        (t1, t2, t3, t4) =>
                        {
                            Assert.AreEqual(Parameter1, t1);
                            Assert.AreEqual(Parameter2, t2);
                            Assert.AreEqual(Parameter3, t3);
                            Assert.AreEqual(Parameter4, t4);
                            return true;
                        },
                        (t1, t2, t3, t4) =>
                        {
                            Assert.AreEqual(Parameter1, t1);
                            Assert.AreEqual(Parameter2, t2);
                            Assert.AreEqual(Parameter3, t3);
                            Assert.AreEqual(Parameter4, t4);
                            return Result;
                        })
                    .Build()
                    .Execute(Parameter1, Parameter2, Parameter3, Parameter4);

            Assert.AreEqual(Result, result);
        }

        #endregion

        #region Five parameters

        [Test]
        public void ResultChain_FiveParameters_NoLinks_DoNothing()
        {
            var result =
               ChainFactory
                   .CreateResultBuilder<int, int, int, int, int, string>()
                   .Build()
                   .Execute(1, 2, 3, 4, 5);

            Assert.AreEqual(default(string), result);
        }

        [TestCase(WhichLink.None, Skip, Skip, Skip, Description = "All links should skip request.")]
        [TestCase(WhichLink.First, Do, Skip, Skip, Description = "First link should handle request.")]
        [TestCase(WhichLink.Second, Skip, Do, Skip, Description = "Second link should handle request.")]
        [TestCase(WhichLink.Third, Skip, Skip, Do)]
        public void ResultChain_FiveParameters(WhichLink expectedLink, bool canFirst, bool canSecond, bool canThird)
        {
            var link = ChainFactory
                .CreateResultBuilder<int, int, int, int, int, WhichLink>()
                .Add((t1, t2, t3, t4, t5) => canFirst, (t1, t2, t3, t4, t5) => WhichLink.First)
                .Add((t1, t2, t3, t4, t5) => canSecond, (t1, t2, t3, t4, t5) => WhichLink.Second)
                .Add((t1, t2, t3, t4, t5) => canThird, (t1, t2, t3, t4, t5) => WhichLink.Third)
                .Build()
                .Execute(1, 2, 3, 4, 5);

            Assert.AreEqual(expectedLink, link);
        }
      
        [Test]
        public void ResultChain_FiveParameters_ParametersUsed()
        {
            var result =
                ChainFactory
                    .CreateResultBuilder<int, int, int, int, int, string>()
                    .Add(
                        (t1, t2, t3, t4, t5) =>
                        {
                            Assert.AreEqual(Parameter1, t1);
                            Assert.AreEqual(Parameter2, t2);
                            Assert.AreEqual(Parameter3, t3);
                            Assert.AreEqual(Parameter4, t4);
                            Assert.AreEqual(Parameter5, t5);
                            return true;
                        },
                        (t1, t2, t3, t4, t5) =>
                        {
                            Assert.AreEqual(Parameter1, t1);
                            Assert.AreEqual(Parameter2, t2);
                            Assert.AreEqual(Parameter3, t3);
                            Assert.AreEqual(Parameter4, t4);
                            Assert.AreEqual(Parameter5, t5);
                            return Result;
                        })
                    .Build()
                    .Execute(Parameter1, Parameter2, Parameter3, Parameter4, Parameter5);

            Assert.AreEqual(Result, result);
        }

        #endregion

        #endregion
    }
}
