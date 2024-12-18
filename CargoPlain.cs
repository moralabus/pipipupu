using System;
using Курсач;

public class CargoPlane : Airplane
{
    public decimal CargoCapacity { get; set; }

    // Конструктор, использующий базовый конструктор
    public CargoPlane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto, decimal cargoCapacity)
        : base(name, model, range, fuelConsumption, manufactureDate, foto)
    {
        CargoCapacity = cargoCapacity;
    }

    // Переопределение метода (см. пункт 3)
    public override string ToString()
    {
        return base.ToString() + $", Грузоподъемность: {CargoCapacity} тонн";
    }
}


