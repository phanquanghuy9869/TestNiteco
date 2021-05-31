using System;
using System.Collections.Generic;
using Niteco.Cores.Interfaces;

namespace Niteco.EventsControl.Events
{
    public class BaseEvent : IEvent
    {
        public string EventName { get; private set; }

        public BaseEvent()
        {
            EventName = this.GetType().Name;
        }
    }
}
