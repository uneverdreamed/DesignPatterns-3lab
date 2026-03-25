using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceData.Core.models
{
    public abstract class CelestialObject // базовый класс для всех космических объектов
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; protected set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime LastUpdated { get; set; }
        protected CelestialObject()
        {
            LastUpdated = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Type}: {Name}";
        }

    }
}
