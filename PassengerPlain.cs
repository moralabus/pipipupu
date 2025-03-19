using System;

namespace Курсач
{
    // Класс PassengerPlane наследуется от базового класса Airplane
    public class PassengerPlane : Airplane
    {
        // Свойство для хранения вместимости пассажиров
        public int PassengerCapacity { get; set; }

        // Конструктор для инициализации нового объекта PassengerPlane
        public PassengerPlane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto, int passengerCapacity, Engine engine)
            : base(name, model, range, fuelConsumption, manufactureDate, foto, engine) // Вызов конструктора базового класса
        {
            // Установка вместимости пассажиров
            PassengerCapacity = passengerCapacity;
        }

        // Переопределение метода GetAircraftType для возврата типа самолета
        public override string GetAircraftType() => "Пассажирский самолет";

        // Переопределение метода AircraftInfo для добавления информации о вместимости пассажиров
        public override string AircraftInfo()
        {
            // Вызываем базовую реализацию и добавляем информацию о вместимости пассажиров
            return base.AircraftInfo() + $", Вместимость пассажиров: {PassengerCapacity}";
        }
    }
}
