using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO; // Add this namespace for file operations

namespace Курсач
{
    public partial class Form1 : Form
    {
        private Airline airline;
        private List<Airplane> airplanes = new List<Airplane>();
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
            airline = new Airline();
            buttonAddAirplaneWithFoto.Click += buttonAddAirplaneWithFoto_Click;
            buttonSort.Click += buttonSortByFuelConsumption_Click_1;
            this.BackColor = Airplane.BackColor;

            // Настройка OpenFileDialog
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog1.Multiselect = false; // Позволяет выбрать только один файл
            buttonSelectFoto.Click += buttonSelectFoto_Click;

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";

            comboBoxModel.Items.AddRange(new string[] { "Boeing 737", "Airbus A320", "Embraer 190" });

            buttonLoadFromFile.Click += buttonLoadFromFile_Click;
            buttonSaveToFile.Click += buttonSaveToFile_Click;
            buttonShowAirplaneInfo.Click += buttonShowAirplaneInfo_Click;
            buttonCalculateAverageConsumption.Click += buttonCalculateAverageConsumption_Click;

            foreach (var airplane in airline.Airplanes)
            {
                airplane.Refueled += (name, fuel) =>
                {
                    MessageBox.Show($"Самолет {name} был заправлен на {fuel} литров.");
                };
            }
        }



        private void buttonSortByRange_Click(object sender, EventArgs e)
        {
            airline.SortByRange();
            UpdateListBox();
        }

        private void buttonFindByFuelRange_Click(object sender, EventArgs e)
        {
            int minRange = (int)numericUpDownMinRange.Value;
            int maxRange = (int)numericUpDownMaxRange.Value;

            var results = airline.GetAircraftByRange(minRange, maxRange);
            listBoxAirplanes.Items.Clear();
            foreach (var airplane in results)
            {
                listBoxAirplanes.Items.Add(airplane.AircraftInfo());
            }
        }

            private void buttonSelectFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void buttonAddAirplaneWithFoto_Click(object sender, EventArgs e)
        {
            string airplaneName = textBoxAirplaneName.Text?.Trim();
            string model = comboBoxModel.SelectedItem?.ToString();
            int range = (int)numericUpDownRange.Value;
            decimal fuelConsumption = numericUpDownFuelConsumption.Value;
            DateTime manufactureDate = dateTimePickerManufactureDate.Value;
            string foto = openFileDialog1.FileName;

            // Проверка имени: если начинается с маленькой буквы, меняем на большую
            if (!string.IsNullOrEmpty(airplaneName) && char.IsLower(airplaneName[0]))
            {
                airplaneName = char.ToUpper(airplaneName[0]) + airplaneName.Substring(1);
            }

            if (string.IsNullOrEmpty(airplaneName) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(foto))
    {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            Airplane newAirplane = new Airplane(airplaneName, model, range, fuelConsumption, manufactureDate, foto);
            airplanes.Add(newAirplane);
            UpdateListBox();
            ClearForm();
            newAirplane.ShowFoto(pictureBoxFoto);
        }

        private void ClearForm()
        {
            textBoxAirplaneName.Clear();
            comboBoxModel.SelectedIndex = -1;
            numericUpDownRange.Value = 0;
            numericUpDownFuelConsumption.Value = 0;
            dateTimePickerManufactureDate.Value = DateTime.Now;
            pictureBoxFoto.Image = null;
        }

        private void buttonSortByFuelConsumption_Click_1(object sender, EventArgs e)
        {
            SortAirplanesByFuelConsumption();
        }

        private void SortAirplanesByFuelConsumption()
        {
            airplanes = airplanes.OrderBy(a => a.FuelConsumption).ToList();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxAirplanes.Items.Clear();
            foreach (var airplane in airplanes)
            {
                string airplaneInfo = string.Format("Имя: {0}, Модель: {1}, Дальность: {2} км, Расход: {3} л/100 км, Возраст: {4} лет",
                  airplane.Name, airplane.Model, airplane.Range, airplane.FuelConsumption, airplane.GetAge());

                listBoxAirplanes.Items.Add(airplaneInfo);
            }
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog loadFileDialog = new OpenFileDialog())
            {
                loadFileDialog.Filter = "Text files (*.txt)|*.txt";
                if (loadFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = loadFileDialog.FileName;
                    try
                    {
                        airplanes = Airplane.ReadFromFile(filePath);
                        UpdateListBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке: {ex.Message}");
                    }
                }
            }
        }


        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                Airplane.WriteToFile(airplanes, filePath);
            }
        }

        private void buttonShowAirplaneInfo_Click(object sender, EventArgs e)
        {
            if (listBoxAirplanes.SelectedIndex != -1)
            {
                Airplane selectedAirplane = airplanes[listBoxAirplanes.SelectedIndex];
                string airplaneInfo = string.Format(
                  "Имя: {0}, Модель: {1}, Дальность: {2} км, Расход: {3} л/100 км, Возраст: {4} лет",
                  selectedAirplane.Name, selectedAirplane.Model, selectedAirplane.Range,
                  selectedAirplane.FuelConsumption, selectedAirplane.GetAge());

                textBoxOutput.Text = airplaneInfo;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите самолет из списка.");
            }
        }

        public void AverageFuelConsumption(List<Airplane> airplanes, out decimal averageConsumption, out string resume)
        {
            if (airplanes.Count > 0)
            {
                averageConsumption = airplanes.Average(a => a.FuelConsumption);
                resume = averageConsumption > 20 ? "Расход выше нормы" : "Расход ниже нормы";
            }
            else
            {
                averageConsumption = 0;
                resume = "Нет данных для расчета";
            }
        }

        private void buttonCalculateAverageConsumption_Click(object sender, EventArgs e)
        {
            decimal averageConsumption;
            string resume;

            AverageFuelConsumption(airplanes, out averageConsumption, out resume);

            textBoxOutput.Text = $"Средний расход топлива: {averageConsumption} л/100 км\n{resume}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAirplaneName_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void FindAirplanesByFuelConsumptionRange(decimal minFuelConsumption, decimal maxFuelConsumption)
        {
            // Фильтруем самолеты, соответствующие заданному диапазону
            var matchingAirplanes = airplanes
                .Where(a => a.FuelConsumption >= minFuelConsumption && a.FuelConsumption <= maxFuelConsumption)
                .ToList();

            // Обновляем ListBox с найденными самолетами
            listBoxAirplanes.Items.Clear();
            foreach (var airplane in matchingAirplanes)
            {
                string airplaneInfo = string.Format("Имя: {0}, Модель: {1}, Дальность: {2} км, Расход: {3} л/100 км, Возраст: {4} лет",
                    airplane.Name, airplane.Model, airplane.Range, airplane.FuelConsumption, airplane.GetAge());
                listBoxAirplanes.Items.Add(airplaneInfo);
            }

            // Если ничего не найдено, показываем сообщение
            if (!matchingAirplanes.Any())
            {
                MessageBox.Show("Не найдено самолетов, соответствующих заданному диапазону потребления топлива.");
            }
        }

        private void buttonFindByFuelRange_Click_1(object sender, EventArgs e)
        {
            // Получаем минимальный и максимальный диапазон из элементов интерфейса
            decimal minFuelConsumption = numericUpDownMinRange.Value;
            decimal maxFuelConsumption = numericUpDownMaxRange.Value;

            // Вызываем метод поиска
            FindAirplanesByFuelConsumptionRange(minFuelConsumption, maxFuelConsumption);
        }

        private void buttonSetNameStyle_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            ColorDialog colorDialog = new ColorDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxAirplaneName.Font = fontDialog.Font;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxAirplaneName.ForeColor = colorDialog.Color;
                }
            }
        }

        private void buttonRefuel_Click(object sender, EventArgs e)
        {
            if (listBoxAirplanes.SelectedIndex != -1)
            {
                var selectedAirplane = airplanes[listBoxAirplanes.SelectedIndex];
                decimal fuelAmount = numericUpDownFuelAmount.Value;
                selectedAirplane.Refuel(fuelAmount);

                MessageBox.Show($"Самолет {selectedAirplane.Name} был заправлен на {fuelAmount} литров.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите самолет для заправки.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBoxAirplanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}