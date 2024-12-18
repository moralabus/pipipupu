﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Курсач
{
    public class Airplane
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Range { get; set; }
        public decimal FuelConsumption { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string Foto { get; set; }

        public static Color BackColor
        {
            get
            {
                int currentDay = DateTime.Now.DayOfWeek.GetHashCode();
                return (currentDay % 2 == 1) ? Color.LightPink : Color.LightBlue;
            }
        }

        public Airplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto)
        {
            Name = name;
            Model = model;
            Range = range;
            FuelConsumption = fuelConsumption;
            ManufactureDate = manufactureDate;
            Foto = foto;
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

        public int GetAge()
        {
            return DateTime.Now.Year - ManufactureDate.Year;
        }

        public override string ToString()
        {
            return $"Самолет: {Name}, Модель: {Model}, Дальность полета: {Range} км, Потребление горючего: {FuelConsumption} л/100км, Дата производства: {ManufactureDate.ToShortDateString()}";
        }

        // Метод для записи данных о самолетах в текстовый файл
        public static void WriteToFile(List<Airplane> airplanes, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Airplane airplane in airplanes)
                {
                    // Запись данных самолета в файл, разделенных запятыми
                    writer.WriteLine($"{airplane.Name},{airplane.Model},{airplane.Range},{airplane.FuelConsumption},{airplane.ManufactureDate.ToShortDateString()},{airplane.Foto}");
                }
            }
        }
        
        public void NameText(TextBox textBox)
        {
        using (FontDialog fontDialog = new FontDialog())
        {
            // Показываем диалоговое окно для выбора шрифта
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = fontDialog.Font;
            }
        }

        using (ColorDialog colorDialog = new ColorDialog())
        {
            // Показываем диалоговое окно для выбора цвета
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = colorDialog.Color;
            }
        }
    }

        public event Action<string, decimal> Refueled;

        public void Refuel(decimal fuelAmount)
        {
            Refueled?.Invoke(Name, fuelAmount); // Уведомляем подписчиков
        }


        // Метод для чтения данных о самолетах из текстового файла
        public static List<Airplane> ReadFromFile(string filePath)
        {
            List<Airplane> airplanes = new List<Airplane>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        airplanes.Add(new Airplane(
                            parts[0].Trim(),  // Удаление пробелов
                            parts[1].Trim(),
                            int.Parse(parts[2]),
                            decimal.Parse(parts[3]),
                            DateTime.Parse(parts[4]),
                            parts[5].Trim()));
                    }
                }
            }
            return airplanes;
        }
    }
}