using Niteco.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niteco.Domains.CrossRoad
{
    /// <summary>
    /// Object model of traffic light
    /// </summary>
    public class TrafficLight
    {
        private Intersection _intersection;
        public TrafficLightColor Color { get; private set; }

        public TrafficLight(Intersection intersection)
        {
            _intersection = intersection;
        }

        public TrafficLight(Intersection intersection, TrafficLightColor color) : this(intersection)
        {
            Color = color;
        }

        public void ChangeColor()
        {
            Color = Color == TrafficLightColor.Green ? TrafficLightColor.Red : TrafficLightColor.Green;
        }
    }
}
