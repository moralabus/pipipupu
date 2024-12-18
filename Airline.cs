using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    // Авиакомпания
    public class Airline
    {
        private List<Aircraft> airplanes = new List<Aircraft>();

        public void AddAircraft(Aircraft airplane) => airplanes.Add(airplane);

        public IEnumerable<Aircraft> GetAircraftByRange(int minRange, int maxRange)
        {
            return airplanes.Where(a => a.Range >= minRange && a.Range <= maxRange);
        }

        public void SortByRange() => airplanes = airplanes.OrderBy(a => a.Range).ToList();

        public Aircraft this[int index] => airplanes[index];

        public int Count => airplanes.Count;

        public IEnumerable<Aircraft> Airplanes => airplanes;
    }
}

