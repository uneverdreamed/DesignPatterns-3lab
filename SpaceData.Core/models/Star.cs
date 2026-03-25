using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceData.Core.models
{
    public class Star : CelestialObject
    {
        public double Temperature { get; set; }
        public double Luminosity { get; set; } // светимость относительно солнца
        public double Mass { get; set; } // масса звезды в массах Солнца
        public double Radius { get; set; } // радиус звезды в радиусах Солнца
        public string SpectralClass { get; set; } = string.Empty; // O, B, A, F, G, K, M
        public double DistanceFromEarth { get; set; } // расстояние от Земли в световых годах
        public Star()
        {
            Type = "Star";
        }

        public override string ToString()
        {
            return $"Звезда {Name} | Класс: {SpectralClass} | Температура: {Temperature:N0} K | Светимость: {Luminosity:F2} L☉";
        }
    }
}
