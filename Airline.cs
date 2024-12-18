using System;
using System.Collections.Generic;
using System.Linq;

namespace Курсач
{
    public class Airline
    {
        private List<Aircraft> airplanes = new List<Aircraft>();

        public void AddAircraft(Aircraft airplane) => airplanes.Add(airplane);

        public IEnumerable<Aircraft> GetAircraftByRange(int minRange, int maxRange)
        {
            return airplanes.Where(a => a.Range >= minRange && a.Range <= maxRange);
        }

        public void SortByRange() => airplanes.OrderBy(a => a.Range).ToList();

        internal void AddAircraft(Airplane newAirplane)
        {
            throw new NotImplementedException();
        }

        public Aircraft this[int index]
        {
            get
            {
                if (index >= 0 && index < airplanes.Count)
                {
                    return airplanes[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс находится вне допустимого диапазона.");
                }
            }
        }

        public int Count => airplanes.Count;

        public List<Aircraft> Airplanes // Изменено на List<Aircraft> для возможности модификации
        {
            get { return airplanes; }
            set { airplanes = value; }
        }
    }
}

