using Niteco.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niteco.Domains.CrossRoad
{
    public class Car
    {
        public string Name { get; private set; }
        public int LeavingRoadTime { get; private set; }
        public Intersection StartingIntersection { get; private set; }

        public Car(string name, int leavingRoadSpeed, Intersection startingIntersection)
        {
            Name = name;
            LeavingRoadTime = leavingRoadSpeed;
            StartingIntersection = startingIntersection;
        }

        /// <summary>
        /// Car stop due to traffic lights
        /// </summary>
        public void StopCar(int time)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Car continue due to traffic lights
        /// </summary>
        public void RestartCar(int time)
        {
            throw new NotImplementedException();
        }
    }
}
