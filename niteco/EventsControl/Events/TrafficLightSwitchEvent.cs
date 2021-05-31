using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niteco.EventsControl.Events
{
    /// <summary>
    /// Event that dispatch when traffic light change color
    /// </summary>
    public class TrafficLightSwitchEvent : BaseEvent
    {
        public int Period { get; private set; }

        public TrafficLightSwitchEvent(int period)
        {
            Period = period;
        }
    }
}
