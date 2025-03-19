using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Курсач
{
    // Абстрактный класс Aircraft
    public abstract class Aircraft: IFlightOperations
    {
        public virtual string Name { get; set; } // Имя самолета
        public string Model { get; set; } // Модель самолета 
        public int Range { get; set; } // Дальность полета в километрах
        public decimal FuelConsumption { get; set; } // Расход топлива в литрах 
        public DateTime ManufactureDate { get; set; } // Дата производства

        // Конструктор класса, принимающий параметры для инициализации свойств 
        public Aircraft(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate)
        {
            Name = CapitalizeName(name); // Присваиваем имя и капитализируем первую букву
            Model = model;
            Range = range;
            FuelConsumption = fuelConsumption;
            ManufactureDate = manufactureDate;
            Refueled += Message;
        }

        // Абстрактный метод для получения типа самолета, реализован в производных классах
        public abstract string GetAircraftType();

        // Метод для получения информации о самолете
        public virtual string AircraftInfo()
        {
            return $"Тип: {GetAircraftType()}, Имя: {Name}, Модель: {Model}, Дальность: {Range} км, Потребление топлива: {FuelConsumption} л/100км";
        }

        // Метод для вычисления возраста самолета
        public int GetAge() => DateTime.Now.Year - ManufactureDate.Year;

        // Приватный метод для капитализации первой буквы имени
        private string CapitalizeName(string name)
        {
            if (char.IsLower(name[0])) // Проверяем, если первая буква строчная
                name = char.ToUpper(name[0]) + name.Substring(1); // Капитализируем первую букву
            return name;
        }

        // Событие, которое будет вызываться при заправке самолета
        public event Action<string, decimal> Refueled;

        // Метод для вызова события Refueled
        protected void OnRefueled(string name, decimal fuelAmount)
        {
            Refueled?.Invoke(name, fuelAmount);
        }
        private void Message(string Name, decimal fuelAmount)
        {
            Console.WriteLine($"Уведомление: {Name} заправлено на {fuelAmount} литров."); // Выводим сообщение о заправке
        }
    }
}
