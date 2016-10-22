// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;

namespace ShogunLib.Events
{
    /// <summary>
    /// Provides extension methods to work with Events.
    /// </summary>
    public static class EventExtensions
    {
        /// <summary>
        /// Safe raise of an event.
        /// </summary>
        /// <param name="handler">Event to be raised.</param>
        /// <param name="sender">Event sender.</param>
        /// <param name="value">Data for <see cref="SimpleEventArgs{T}.Value"/>.</param>
        /// <typeparam name="TEventArgs">Type of the EventArgs class which contains <paramref name="value"/>.</typeparam>
        /// <typeparam name="TValue">Type of the <see cref="SimpleEventArgs{T}.Value"/>.</typeparam>
        public static void Raise<TEventArgs, TValue>(this EventHandler<TEventArgs> handler, object sender, TValue value)
            where TEventArgs : SimpleEventArgs<TValue>, new()
        {
            handler.Raise<TEventArgs>(sender, new TEventArgs { Value = value });
        }

        /// <summary>
        /// Safe raise of an event.
        /// </summary>
        /// <typeparam name="TEventArgs">Type of the event arguments.</typeparam>
        /// <param name="handler">Event to be raised.</param>
        /// <param name="sender">Event sender.</param>
        /// <param name="args">Event args.</param>
        public static void Raise<TEventArgs>(this EventHandler<TEventArgs> handler, object sender, TEventArgs args)
            where TEventArgs : EventArgs
        {
            var temp = handler;

            if (temp != null)
            {
                temp(sender, args);
            }
        }
    }
}
