using Niteco.Cores.Interfaces;
using Niteco.Events;
using Niteco.EventsControl;
using Niteco.Simulators;
using System;

namespace Niteco
{
    class Program
    {
        /// <summary>
        /// Register events subscription and run the simulator
        /// Because  lack of time i couldn't implement Dependency injection here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region this should be dependency injection
            var subscriptionManager = new EventsSubscriptionManager();
            var eventManager = new EventsManager(subscriptionManager);
            var simulator = new EventSimulators(eventManager);
            #endregion
            
            // register the subscription
            subscriptionManager.Register();
            //Add custom subscription here

            // simulator generate the events
            simulator.Simulate();

            var stillHaveEvents = true;
            //system runs a loop which checks the queue and gradually runs individual events
            while (stillHaveEvents)
            {
                stillHaveEvents = eventManager.Trigger();
            }
        }
    }
}
