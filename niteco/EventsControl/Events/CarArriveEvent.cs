using System;
using System.Collections.Generic;
using Niteco.Cores.Interfaces;
using Niteco.Enums;

namespace Niteco.EventsControl.Events
{
    /// <summary>
    /// Event that dispatch when a car arrive
    /// </summary>
    public class CarArriveEvent : BaseEvent
    {
        /// <summary>
        /// Intersection that the car arrive
        /// </summary>
        public Intersection StartIntersection { get; private set; }

        public CarArriveEvent(Intersection startIntersection)
        {
            StartIntersection = startIntersection;
        }
    }
}
