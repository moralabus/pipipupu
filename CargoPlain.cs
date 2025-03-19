using System;

namespace Курсач
{
    // Класс представляет собой грузовой самолет и наследует от класса Airplane
    public class CargoPlane : Airplane
    {
        // Свойство для получения имени грузового самолета с префиксом "Cargo"
        public override string Name { get => $"Cargo {base.Name}"; set => base.Name = value; }

        // Поле для хранения информации о двигателе грузового самолета
        public Engine Engine;

        // Свойство для хранения грузоподъемности самолета
        public decimal CargoCapacity { get; set; }

        // Конструктор класса CargoPlane, принимающий параметры для инициализации
        public CargoPlane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto, decimal cargoCapacity, Engine engine)
            : base(name, model, range, fuelConsumption, manufactureDate, foto, engine) // Вызов конструктора базового класса Airplane
        {
            // Инициализация свойства CargoCapacity
            CargoCapacity = cargoCapacity;

            // Инициализация поля Engine с заданной моделью и мощностью
            this.Engine = new Engine("some model", 1); // Замените параметры на необходимые
        }


        // Метод для получения типа воздушного судна, конкретно для грузового самолета
        public override string GetAircraftType() => "Грузовой самолет";


        // Метод для получения информации о грузовом самолете с добавлением информации о грузоподъемности
        public override string AircraftInfo()
        {
            return base.AircraftInfo() + $", Грузоподъемность: {CargoCapacity} тонн";
        }
    }
}
