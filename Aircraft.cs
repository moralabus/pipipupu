using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Курсач
{
    // Абстрактный класс Aircraft
    public abstract class Aircraft
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Range { get; set; }
        public decimal FuelConsumption { get; set; }
        public DateTime ManufactureDate { get; set; }

        public Aircraft(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate)
        {
            Name = CapitalizeName(name);
            Model = model;
            Range = range;
            FuelConsumption = fuelConsumption;
            ManufactureDate = manufactureDate;
        }

        public abstract string GetAircraftType();

        public virtual string AircraftInfo()
        {
            return $"Тип: {GetAircraftType()}, Имя: {Name}, Модель: {Model}, Дальность: {Range} км, Потребление топлива: {FuelConsumption} л/100км";
        }

        public int GetAge() => DateTime.Now.Year - ManufactureDate.Year;

        private string CapitalizeName(string name)
        {
            if (char.IsLower(name[0]))
                name = char.ToUpper(name[0]) + name.Substring(1);
            return name;
        }

        public event Action<string, decimal> Refueled;

        public void Refuel(decimal fuelAmount)
        {
            Refueled?.Invoke(Name, fuelAmount);
        }
    }
}