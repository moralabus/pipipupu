using System; 

namespace Курсач
{
    // Класс Engine, представляющий собой двигатель
    public class Engine
    {
        // Свойство для хранения модели двигателя
        public string Model { get; set; }

        // Свойство для хранения мощности двигателя
        public int Power { get; set; }

        // Конструктор класса Engine, принимающий модель и мощность в качестве параметров
        public Engine(string model, int power)
        {
            Model = model; // Инициализация модели двигателя
            Power = power; // Инициализация мощности двигателя
        }

        // Метод для проверки совместимости двигателя с самолетом
        public bool IsCompatibleWithAirplane(Airplane airplane)
        {
            // Проверяем, совместим ли двигатель (например, мощность не меньше дальности / 10)
            return Power >= airplane.Range / 10; // Возвращает true, если мощность достаточна
        }

        // Переопределение метода ToString для удобного отображения информации о двигателе 
        public override string ToString()
        {
            return $"Модель: {Model}, Мощность: {Power} л.с."; // Форматированный вывод информации о двигателе
        }
    }
}
