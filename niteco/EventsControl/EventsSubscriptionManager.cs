using System;
using System.Collections.Generic;
using Niteco.Cores.Interfaces;

namespace Niteco.Events
{
    /// <summary>
    /// Manage Event subscription
    /// </summary>
    public class EventsSubscriptionManager : IEventsSubscriptionManager
    {
        // mapping event name with it's listener
        private Dictionary<string, List<IEventListener>> _eventSubscriser;

        public EventsSubscriptionManager()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initialize the default mapping between events and eventListeners
        /// </summary>
        public void Register()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Subcrise a listener to a event
        /// </summary>
        /// <param name="listener">Event handler</param>
        /// <param name="ev">Event</param>
        public void Register(IEventListener listener, IEvent ev) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get event handler of 1 event
        /// </summary>
        /// <param name="listener">event</param>
        /// <returns>List of event handler</returns>
        public IEnumerable<IEventListener> GetListener(IEvent ev)
        {
            throw new NotImplementedException();
        }
    }
}
