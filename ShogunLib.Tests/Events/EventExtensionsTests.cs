// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using NUnit.Framework;
using ShogunLib.Events;

namespace ShogunLib.Tests.Events
{
    [TestFixture]
    public sealed class EventExtensionsTests
    {
        [Test]
        public void Raise_General()
        {
            // Prepare
            var eventRaised = false;
            var holder = new EventHolder();

            holder.Event1 += (sender, userful) => { eventRaised = true; };

            // Action
            holder.OnEvent1();

            // Check
            Assert.IsTrue(eventRaised, "Event didn't raise.");
        }

        [Test]
        public void Raise_WithSimpleEventArgs()
        {
            // Prepare
            var eventRaised = false;
            var holder = new EventHolder();

            holder.Event2 += (sender, userful) => { eventRaised = true; };

            // Action
            holder.OnEvent2();

            // Check
            Assert.IsTrue(eventRaised, "Event didn't raise.");
        }

        private class EventHolder
        {
            public event EventHandler<UsefulEventArgs> Event1;

            public event EventHandler<SimpleEventArgs<Useful>> Event2;

            public void OnEvent1()
            {
                Event1.Raise<UsefulEventArgs>(this, new UsefulEventArgs());
            }

            public void OnEvent2()
            {
                Event2.Raise(this, new Useful());
            }
        }
        
        private class Useful
        {
        }

        private class UsefulEventArgs : EventArgs
        {
        }
    }
}
