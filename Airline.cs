using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Курсач
{
    // Класс Airline, представляющий авиакомпанию и её парк самолетов
    public class Airline
    {
        // Список для хранения самолетов
        private List<Aircraft> airplanes = new List<Aircraft>(); // Агрегация: класс Airline содержит множество объектов Aircraft

        // Метод для добавления самолета в список
        public void AddAircraft(Aircraft airplane) => airplanes.Add(airplane);

        // Метод для удаления указанного самолета из списка
        public void RemoveAircraft(Aircraft airplane) => airplanes.Remove(airplane); // Метод удаления самолета

        // Метод для получения самолетов в заданном диапазоне дальности полета
        public IEnumerable<Aircraft> GetAircraftByRange(int minRange, int maxRange)
        {
            // Фильтруем список самолетов по условиям дальности
            return airplanes.Where(a => a.Range >= minRange && a.Range <= maxRange);
        }

        // Метод для сортировки самолетов по дальности полета
        public void SortByRange() => airplanes = airplanes.OrderBy(a => a.Range).ToList();

        // Индексатор для доступа к самолетам по индексу
        public Aircraft this[int index]
        {
            get
            {
                // Проверяем, что индекс находится в допустимом диапазоне
                if (index >= 0 && index < airplanes.Count)
                {
                    return airplanes[index]; // Возвращаем самолет по индексу
                }
                else
                {
                    // Если индекс вне диапазона, генерируем исключение
                    throw new IndexOutOfRangeException("Индекс находится вне допустимого диапазона.");
                }
            }
        }

        // Статическое свойство для получения цвета фона в зависимости от дня недели
        public static Color BackColor
        {
            get
            {
                // Получаем текущий день недели и используем его для определения цвета
                int currentDay = DateTime.Now.DayOfWeek.GetHashCode();
                // Если день недели нечётный, возвращаем розовый цвет, иначе голубой
                return (currentDay % 2 == 1) ? Color.LightPink : Color.LightBlue;
            }
        }

        // Свойство для получения количества самолетов в парке
        public int Count => airplanes.Count;

        // Свойство для доступа к списку самолетов
        public List<Aircraft> Airplanes
        {
            get { return airplanes; } // Возвращаем текущий список самолетов
            set { airplanes = value; } // Позволяем устанавливать новый список самолетов
        }
    }
}
