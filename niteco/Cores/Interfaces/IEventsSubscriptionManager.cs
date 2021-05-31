using System;
using System.Collections.Generic;

namespace Niteco.Cores.Interfaces
{
    public interface IEventsSubscriptionManager
    {
        void Register();

        /// <summary>
        /// Subcrise a listener to a event
        /// </summary>
        /// <param name="listener">Event handler</param>
        /// <param name="ev">Event</param>
        void Register(IEventListener listener, IEvent ev);

        /// <summary>
        /// Get event handler of 1 event
        /// </summary>
        /// <param name="listener">event</param>
        /// <returns>List of event handler</returns>
        IEnumerable<IEventListener> GetListener(IEvent ev);
    }
}
