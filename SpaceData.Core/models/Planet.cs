using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceData.Core.models
{
    public class Planet : CelestialObject
    {
        public double Mass { get; set; }
        public double Radius { get; set; }
        public double DistanceFromSun { get; set; }
        public double OrbitalPeriod { get; set; }
        public bool HasAtmosphere { get; set; }
        public int Moons { get; set; }
        public Planet()
        {
            Type = "Planet";
        }
        public override string ToString()
        {
            return $"Планета {Name} | Масса: {Mass:E2} кг | Радиус: {Radius:N0} км | Спутников: {Moons}";
        }
    }
}
