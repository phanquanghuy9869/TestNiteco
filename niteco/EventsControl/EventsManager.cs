using Niteco.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niteco.EventsControl
{
    /// <summary>
    /// Management centralization of events and event handlers
    /// </summary>
    public class EventsManager : IEventManager
    {
        private Queue<IEvent> _events;
        private readonly IEventsSubscriptionManager _subscriptionManager;

        public EventsManager(IEventsSubscriptionManager subscriptionManager)
        {
            _events = new Queue<IEvent>();
            _subscriptionManager = subscriptionManager;
        }

        public void AddEvent(IEvent ev)
        {
            _events.Enqueue(ev);
        }

        /// <summary>
        /// Retrieve and execute an event
        /// </summary>
        /// <returns>True if 1 event is triggered, false if there's no event left</returns>
        public bool Trigger()
        {
            var ev = _events.Dequeue();
            if (ev == null) return false;
            return Trigger(ev);
        }

        private bool Trigger(IEvent ev)
        {
            var handlers = _subscriptionManager.GetListener(ev);
            foreach (var handler in handlers)
            {
                handler.Execute();
            }
            return true;
        }
    }
}
