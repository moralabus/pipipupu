using System;
using Курсач;

public class PassengerPlane : Airplane
{
    public int PassengerCapacity { get; set; }

    // Конструктор, использующий базовый конструктор
    public PassengerPlane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto, int passengerCapacity)
        : base(name, model, range, fuelConsumption, manufactureDate, foto)
    {
        PassengerCapacity = passengerCapacity;
    }

    // Переопределение метода (см. пункт 3)
    public override string ToString()
    {
        return base.ToString() + $", Вместимость пассажиров: {PassengerCapacity}";
    }
}
