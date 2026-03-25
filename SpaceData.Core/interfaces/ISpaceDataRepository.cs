using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceData.Core.models;

namespace SpaceData.Core.interfaces
{
    public interface ISpaceDataRepository // интерфейс репозитория для доступа к данным о космических объектах
    {
        Planet? GetPlanet(string name);
        Star? GetStar(string name);
        Galaxy? GetGalaxy(string name);
        IEnumerable<string> GetAvailablePlanets();
        IEnumerable<string> GetAvailableStars();
        IEnumerable<string> GetAvailableGalaxies();
    }
}
