namespace Курсач {  
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelectFoto = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.dateTimePickerManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAirplaneName = new System.Windows.Forms.TextBox();
            this.listBoxAirplanes = new System.Windows.Forms.ListBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonAddAirplaneWithFoto = new System.Windows.Forms.Button();
            this.numericUpDownFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonShowAirplaneInfo = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.buttonCalculateAverageConsumption = new System.Windows.Forms.Button();
            this.buttonFindByFuelRange = new System.Windows.Forms.Button();
            this.numericUpDownMinRange = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxRange = new System.Windows.Forms.NumericUpDown();
            this.дальность = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonGetAirplaneByIndex = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSetNameStyle = new System.Windows.Forms.Button();
            this.numericUpDownFuelAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonRefuel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonPassenger = new System.Windows.Forms.RadioButton();
            this.numericUpDownPassengerCapacity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCargoCapacity = new System.Windows.Forms.NumericUpDown();
            this.radioButtonCargo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRange)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelAmount)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassengerCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargoCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectFoto
            // 
            this.buttonSelectFoto.Location = new System.Drawing.Point(375, 30);
            this.buttonSelectFoto.Name = "buttonSelectFoto";
            this.buttonSelectFoto.Size = new System.Drawing.Size(280, 36);
            this.buttonSelectFoto.TabIndex = 55;
            this.buttonSelectFoto.Text = "выбрать фото";
            this.buttonSelectFoto.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(375, 74);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(280, 280);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 54;
            this.pictureBoxFoto.TabStop = false;
            // 
            // dateTimePickerManufactureDate
            // 
            this.dateTimePickerManufactureDate.Location = new System.Drawing.Point(28, 233);
            this.dateTimePickerManufactureDate.Name = "dateTimePickerManufactureDate";
            this.dateTimePickerManufactureDate.Size = new System.Drawing.Size(321, 31);
            this.dateTimePickerManufactureDate.TabIndex = 51;
            // 
            // textBoxAirplaneName
            // 
            this.textBoxAirplaneName.Location = new System.Drawing.Point(28, 74);
            this.textBoxAirplaneName.Name = "textBoxAirplaneName";
            this.textBoxAirplaneName.Size = new System.Drawing.Size(321, 31);
            this.textBoxAirplaneName.TabIndex = 50;
            this.textBoxAirplaneName.Text = "Имя самолета";
            this.textBoxAirplaneName.TextChanged += new System.EventHandler(this.textBoxAirplaneName_TextChanged);
            // 
            // listBoxAirplanes
            // 
            this.listBoxAirplanes.FormattingEnabled = true;
            this.listBoxAirplanes.HorizontalScrollbar = true;
            this.listBoxAirplanes.ItemHeight = 25;
            this.listBoxAirplanes.Location = new System.Drawing.Point(47, 544);
            this.listBoxAirplanes.Name = "listBoxAirplanes";
            this.listBoxAirplanes.Size = new System.Drawing.Size(684, 304);
            this.listBoxAirplanes.TabIndex = 49;
            this.listBoxAirplanes.SelectedIndexChanged += new System.EventHandler(this.listBoxAirplanes_SelectedIndexChanged);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(34, 30);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(211, 42);
            this.buttonSort.TabIndex = 48;
            this.buttonSort.Text = "сортировка";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // buttonAddAirplaneWithFoto
            // 
            this.buttonAddAirplaneWithFoto.Location = new System.Drawing.Point(28, 318);
            this.buttonAddAirplaneWithFoto.Name = "buttonAddAirplaneWithFoto";
            this.buttonAddAirplaneWithFoto.Size = new System.Drawing.Size(321, 36);
            this.buttonAddAirplaneWithFoto.TabIndex = 47;
            this.buttonAddAirplaneWithFoto.Text = "добавить самолет";
            this.buttonAddAirplaneWithFoto.UseVisualStyleBackColor = true;
            this.buttonAddAirplaneWithFoto.Click += new System.EventHandler(this.buttonAddAirplaneWithFoto_Click);
            // 
            // numericUpDownFuelConsumption
            // 
            this.numericUpDownFuelConsumption.Location = new System.Drawing.Point(248, 192);
            this.numericUpDownFuelConsumption.Name = "numericUpDownFuelConsumption";
            this.numericUpDownFuelConsumption.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownFuelConsumption.TabIndex = 46;
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Location = new System.Drawing.Point(248, 155);
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownRange.TabIndex = 45;
            this.numericUpDownRange.Tag = "";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(28, 116);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(321, 33);
            this.comboBoxModel.TabIndex = 44;
            this.comboBoxModel.Text = "выберите модель самолета";
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(34, 127);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(211, 38);
            this.buttonLoadFromFile.TabIndex = 56;
            this.buttonLoadFromFile.Text = "из файла";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(34, 78);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(211, 42);
            this.buttonSaveToFile.TabIndex = 57;
            this.buttonSaveToFile.Text = " в файл";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(6, 72);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(350, 31);
            this.textBoxOutput.TabIndex = 58;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // buttonShowAirplaneInfo
            // 
            this.buttonShowAirplaneInfo.Location = new System.Drawing.Point(114, 25);
            this.buttonShowAirplaneInfo.Name = "buttonShowAirplaneInfo";
            this.buttonShowAirplaneInfo.Size = new System.Drawing.Size(46, 36);
            this.buttonShowAirplaneInfo.TabIndex = 59;
            this.buttonShowAirplaneInfo.Text = "!";
            this.buttonShowAirplaneInfo.UseVisualStyleBackColor = true;
            this.buttonShowAirplaneInfo.Click += new System.EventHandler(this.buttonShowAirplaneInfo_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonCalculateAverageConsumption
            // 
            this.buttonCalculateAverageConsumption.Location = new System.Drawing.Point(34, 171);
            this.buttonCalculateAverageConsumption.Name = "buttonCalculateAverageConsumption";
            this.buttonCalculateAverageConsumption.Size = new System.Drawing.Size(211, 39);
            this.buttonCalculateAverageConsumption.TabIndex = 61;
            this.buttonCalculateAverageConsumption.Text = "ср расход топлива";
            this.buttonCalculateAverageConsumption.UseVisualStyleBackColor = true;
            // 
            // buttonFindByFuelRange
            // 
            this.buttonFindByFuelRange.Location = new System.Drawing.Point(17, 171);
            this.buttonFindByFuelRange.Name = "buttonFindByFuelRange";
            this.buttonFindByFuelRange.Size = new System.Drawing.Size(163, 43);
            this.buttonFindByFuelRange.TabIndex = 63;
            this.buttonFindByFuelRange.Text = "фильтровать";
            this.buttonFindByFuelRange.UseVisualStyleBackColor = true;
            this.buttonFindByFuelRange.Click += new System.EventHandler(this.buttonFindByFuelRange_Click_1);
            // 
            // numericUpDownMinRange
            // 
            this.numericUpDownMinRange.Location = new System.Drawing.Point(93, 97);
            this.numericUpDownMinRange.Name = "numericUpDownMinRange";
            this.numericUpDownMinRange.Size = new System.Drawing.Size(87, 31);
            this.numericUpDownMinRange.TabIndex = 64;
            // 
            // numericUpDownMaxRange
            // 
            this.numericUpDownMaxRange.Location = new System.Drawing.Point(93, 134);
            this.numericUpDownMaxRange.Name = "numericUpDownMaxRange";
            this.numericUpDownMaxRange.Size = new System.Drawing.Size(87, 31);
            this.numericUpDownMaxRange.TabIndex = 65;
            this.numericUpDownMaxRange.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // дальность
            // 
            this.дальность.AutoSize = true;
            this.дальность.Location = new System.Drawing.Point(47, 155);
            this.дальность.Name = "дальность";
            this.дальность.Size = new System.Drawing.Size(195, 25);
            this.дальность.TabIndex = 66;
            this.дальность.Text = "Дальность полета";
            this.дальность.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Расход топлива";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownFuelConsumption);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxModel);
            this.groupBox1.Controls.Add(this.дальность);
            this.groupBox1.Controls.Add(this.numericUpDownRange);
            this.groupBox1.Controls.Add(this.textBoxAirplaneName);
            this.groupBox1.Controls.Add(this.dateTimePickerManufactureDate);
            this.groupBox1.Controls.Add(this.pictureBoxFoto);
            this.groupBox1.Controls.Add(this.buttonSelectFoto);
            this.groupBox1.Controls.Add(this.buttonAddAirplaneWithFoto);
            this.groupBox1.Location = new System.Drawing.Point(47, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 433);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обязательные данные о самолете";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonFindByFuelRange);
            this.groupBox2.Controls.Add(this.numericUpDownMinRange);
            this.groupBox2.Controls.Add(this.numericUpDownMaxRange);
            this.groupBox2.Location = new System.Drawing.Point(755, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 230);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "фильтрация";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 69;
            this.label3.Text = "макс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "мин";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 70;
            this.label4.Text = "список самолетов";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonGetAirplaneByIndex);
            this.groupBox3.Controls.Add(this.textBoxOutput);
            this.groupBox3.Controls.Add(this.buttonShowAirplaneInfo);
            this.groupBox3.Location = new System.Drawing.Point(974, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 115);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "найти информацию о выбранном самолете";
            // 
            // buttonGetAirplaneByIndex
            // 
            this.buttonGetAirplaneByIndex.Location = new System.Drawing.Point(165, 25);
            this.buttonGetAirplaneByIndex.Name = "buttonGetAirplaneByIndex";
            this.buttonGetAirplaneByIndex.Size = new System.Drawing.Size(92, 36);
            this.buttonGetAirplaneByIndex.TabIndex = 81;
            this.buttonGetAirplaneByIndex.Text = "индекс самолета";
            this.buttonGetAirplaneByIndex.UseVisualStyleBackColor = true;
            this.buttonGetAirplaneByIndex.Click += new System.EventHandler(this.buttonGetAirplaneByIndex_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSetNameStyle);
            this.groupBox4.Controls.Add(this.buttonLoadFromFile);
            this.groupBox4.Controls.Add(this.buttonSort);
            this.groupBox4.Controls.Add(this.buttonSaveToFile);
            this.groupBox4.Controls.Add(this.buttonCalculateAverageConsumption);
            this.groupBox4.Location = new System.Drawing.Point(755, 544);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(455, 280);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "дрругие кнопки";
            // 
            // buttonSetNameStyle
            // 
            this.buttonSetNameStyle.Location = new System.Drawing.Point(34, 216);
            this.buttonSetNameStyle.Name = "buttonSetNameStyle";
            this.buttonSetNameStyle.Size = new System.Drawing.Size(211, 37);
            this.buttonSetNameStyle.TabIndex = 73;
            this.buttonSetNameStyle.Text = "шрифт цвет";
            this.buttonSetNameStyle.UseVisualStyleBackColor = true;
            this.buttonSetNameStyle.Click += new System.EventHandler(this.buttonSetNameStyle_Click);
            // 
            // numericUpDownFuelAmount
            // 
            this.numericUpDownFuelAmount.Location = new System.Drawing.Point(93, 35);
            this.numericUpDownFuelAmount.Name = "numericUpDownFuelAmount";
            this.numericUpDownFuelAmount.Size = new System.Drawing.Size(87, 31);
            this.numericUpDownFuelAmount.TabIndex = 73;
            // 
            // buttonRefuel
            // 
            this.buttonRefuel.Location = new System.Drawing.Point(49, 75);
            this.buttonRefuel.Name = "buttonRefuel";
            this.buttonRefuel.Size = new System.Drawing.Size(131, 40);
            this.buttonRefuel.TabIndex = 10;
            this.buttonRefuel.Text = "Заправить";
            this.buttonRefuel.UseVisualStyleBackColor = true;
            this.buttonRefuel.Click += new System.EventHandler(this.buttonRefuel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.numericUpDownFuelAmount);
            this.groupBox5.Controls.Add(this.buttonRefuel);
            this.groupBox5.Location = new System.Drawing.Point(755, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(197, 121);
            this.groupBox5.TabIndex = 74;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "заправка";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 75;
            this.label5.Text = "литры";
            // 
            // radioButtonPassenger
            // 
            this.radioButtonPassenger.AutoSize = true;
            this.radioButtonPassenger.Location = new System.Drawing.Point(1013, 134);
            this.radioButtonPassenger.Name = "radioButtonPassenger";
            this.radioButtonPassenger.Size = new System.Drawing.Size(186, 29);
            this.radioButtonPassenger.TabIndex = 75;
            this.radioButtonPassenger.TabStop = true;
            this.radioButtonPassenger.Text = "пассажирский";
            this.radioButtonPassenger.UseVisualStyleBackColor = true;
            this.radioButtonPassenger.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // numericUpDownPassengerCapacity
            // 
            this.numericUpDownPassengerCapacity.Location = new System.Drawing.Point(1013, 177);
            this.numericUpDownPassengerCapacity.Name = "numericUpDownPassengerCapacity";
            this.numericUpDownPassengerCapacity.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownPassengerCapacity.TabIndex = 78;
            // 
            // numericUpDownCargoCapacity
            // 
            this.numericUpDownCargoCapacity.Location = new System.Drawing.Point(1013, 269);
            this.numericUpDownCargoCapacity.Name = "numericUpDownCargoCapacity";
            this.numericUpDownCargoCapacity.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownCargoCapacity.TabIndex = 80;
            // 
            // radioButtonCargo
            // 
            this.radioButtonCargo.AutoSize = true;
            this.radioButtonCargo.Location = new System.Drawing.Point(1013, 226);
            this.radioButtonCargo.Name = "radioButtonCargo";
            this.radioButtonCargo.Size = new System.Drawing.Size(132, 29);
            this.radioButtonCargo.TabIndex = 79;
            this.radioButtonCargo.TabStop = true;
            this.radioButtonCargo.Text = "грузовой";
            this.radioButtonCargo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 1132);
            this.Controls.Add(this.numericUpDownCargoCapacity);
            this.Controls.Add(this.radioButtonCargo);
            this.Controls.Add(this.numericUpDownPassengerCapacity);
            this.Controls.Add(this.radioButtonPassenger);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxAirplanes);
            this.Name = "Form1";
            this.Text = "e";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRange)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelAmount)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassengerCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargoCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFoto;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.DateTimePicker dateTimePickerManufactureDate;
        private System.Windows.Forms.TextBox textBoxAirplaneName;
        private System.Windows.Forms.ListBox listBoxAirplanes;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonAddAirplaneWithFoto;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelConsumption;
        private System.Windows.Forms.NumericUpDown numericUpDownRange;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonShowAirplaneInfo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonCalculateAverageConsumption;
        private System.Windows.Forms.Button buttonFindByFuelRange;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxRange;
        private System.Windows.Forms.NumericUpDown numericUpDownMinRange;
        private System.Windows.Forms.Label дальность;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSetNameStyle;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelAmount;
        private System.Windows.Forms.Button buttonRefuel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonPassenger;
        private System.Windows.Forms.NumericUpDown numericUpDownPassengerCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownCargoCapacity;
        private System.Windows.Forms.RadioButton radioButtonCargo;
        private System.Windows.Forms.Button buttonGetAirplaneByIndex;
    }
}

