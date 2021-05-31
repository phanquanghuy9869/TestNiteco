using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niteco.Cores.Interfaces
{
    public interface IEventManager
    {
        void AddEvent(IEvent ev);
        bool Trigger();
    }
}
