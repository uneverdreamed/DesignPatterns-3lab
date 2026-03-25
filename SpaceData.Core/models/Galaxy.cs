using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceData.Core.models
{
    public class Galaxy : CelestialObject
    {
        public string GalaxyType { get; set; } = string.Empty; // Spiral, Elliptical, Irregular
        public long StarCount { get; set; }
        public double Diameter { get; set; } // диаметр в световых годах
        public double DistanceFromMilkyWay { get; set; } // расстояние от Млечного Пути в миллионах световых лет
        public double Mass { get; set; } // масса галактики в массах Солнца
        public string Constellation { get; set; } = string.Empty; // созвездие, в котором видна галактика
        public Galaxy()
        {
            Type = "Galaxy";
        }

        public override string ToString()
        {
            return $"Галактика {Name} | Тип: {GalaxyType} | Звёзд: ~{StarCount:N0} | Расстояние: {DistanceFromMilkyWay:F2} млн св. лет";
        }
    }
}
