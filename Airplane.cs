using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Курсач
{
    public class Airplane : Aircraft, IFlightOperations, IFuelOperations
    {
        public string Foto { get; set; }
        public Engine Engine { get; set; } // Композиция

        public Airplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto, Engine engine)
            : base(name, model, range, fuelConsumption, manufactureDate)
        {
            Foto = foto;
            Engine = engine ?? throw new ArgumentNullException(nameof(engine), "Engine cannot be null");
        }

        public override string GetAircraftType() => "Самолет";

        public override string AircraftInfo()
        {
            return base.AircraftInfo() + $", Двигатель: [{Engine}]";
        }

        public void ShowFoto(PictureBox pictureBox)
        {
            if (!string.IsNullOrEmpty(Foto))
            {
                try
                {
                    pictureBox.Image = Image.FromFile(Foto);
                    pictureBox.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                }
            }
            else
            {
                pictureBox.Image = null;
                pictureBox.Visible = false;
            }
        }

        public static Color BackColor
        {
            get
            {
                int currentDay = DateTime.Now.DayOfWeek.GetHashCode();
                return (currentDay % 2 == 1) ? Color.LightPink : Color.LightBlue;
            }
        }

        public void Refuel(decimal fuelAmount)
        {
            OnRefueled(Name, fuelAmount); // Вызываем защищенный метод
        }
        public int GetAge()
        {
            return DateTime.Now.Year - ManufactureDate.Year; // Реализация IFlightOperations
        }
        public static void WriteToFile(List<Airplane> airplanes, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var airplane in airplanes)
                {
                    writer.WriteLine($"{airplane.Name},{airplane.Model},{airplane.Range},{airplane.FuelConsumption},{airplane.ManufactureDate},{airplane.Foto}");
                }
            }
        }

        public static List<Airplane> ReadFromFile(string filePath)
        {
            List<Airplane> airplanes = new List<Airplane>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length >= 6)
                    {
                        airplanes.Add(new Airplane(
                            parts[0], parts[1], int.Parse(parts[2]), decimal.Parse(parts[3]),
                            DateTime.Parse(parts[4]), parts[5], new Engine("Default", 1000)));
                    }
                }
            }
            return airplanes;
        }
    }
}
