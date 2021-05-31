using Niteco.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niteco.Simulators
{
    /// <summary>
    /// Simulate the events of cars and traffic lights
    /// </summary>
    public class EventSimulators
    {
        private readonly IEventManager _eventManager;

        public EventSimulators(IEventManager manager)
        {
            _eventManager = manager;
        }

        public void Simulate()
        {
            Parallel.Invoke(SimulateCars, SimulateTrafficLights);
        }

        /// <summary>
        /// Simulate events of cars and add to event manager
        /// </summary>
        private void SimulateCars()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Simulate events of traffic lights and add to event manager
        /// </summary>
        private void SimulateTrafficLights()
        {
            throw new NotImplementedException();
        }

    }
}
