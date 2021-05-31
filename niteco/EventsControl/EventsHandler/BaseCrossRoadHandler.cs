using Niteco.Cores.Interfaces;
using Niteco.Domains.CrossRoad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niteco.EventsControl.EventsHandler
{
    public abstract class BaseCrossRoadHandler : IEventListener
    {
        protected CrossRoad _crossRoad;

        public BaseCrossRoadHandler()
        {
            _crossRoad = CrossRoad.Instance;
        }

        public abstract void Execute();
    }
}
