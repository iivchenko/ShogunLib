// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using NUnit.Framework;
using ShogunLib.Events;

namespace ShogunLib.Samples
{
    [TestFixture(Category = Constants.Category)]
    public sealed class EventsSamples
    {
        public event EventHandler<EventArgs> Event1;

        public event EventHandler<SimpleEventArgs<Tuple<string, int>>> Event2;

        [Test]
        public void Sample()
        {
            var event1 = nameof(Event1);
            var event2 = nameof(Event2);

            Event1 += (sender, args) => Console.WriteLine($"{event1} Hi");
            Event2 += (sender, args) => Console.WriteLine($"{event2} {args.Value.Item1} {args.Value.Item2}");

            // Safe raise of Event1 with your own EventArgs instance
            Event1.Raise<EventArgs>(this, new EventArgs());

            // Safe raise of Event2 with SimpleEventArgs<Tuple<string, int>> instance
            // and you don't need to provide SimpleEventArgs instace, 
            // code will do it insted of you.
            Event2.Raise(this, new Tuple<string, int>("Hello", 10));
        }
        // Sample output
        // Event1 Hi
        // Event2 Hello 10
    }
}
