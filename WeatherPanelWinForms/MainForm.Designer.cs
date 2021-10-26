namespace WeatherPanelWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CurrentCityLabel = new System.Windows.Forms.Label();
            this.CurrentTemperatureLabel = new System.Windows.Forms.Label();
            this.CurrentHumidityLabel = new System.Windows.Forms.Label();
            this.CurrentPressureLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangeCityTextBox = new System.Windows.Forms.TextBox();
            this.ChangeCityButton = new System.Windows.Forms.Button();
            this.CurrentWeatherPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentWindSpeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentWeatherPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentCityLabel
            // 
            this.CurrentCityLabel.AutoSize = true;
            this.CurrentCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentCityLabel.Location = new System.Drawing.Point(10, 12);
            this.CurrentCityLabel.Name = "CurrentCityLabel";
            this.CurrentCityLabel.Size = new System.Drawing.Size(323, 55);
            this.CurrentCityLabel.TabIndex = 3;
            this.CurrentCityLabel.Text = "*NameOfCity*";
            this.CurrentCityLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CurrentTemperatureLabel
            // 
            this.CurrentTemperatureLabel.AutoSize = true;
            this.CurrentTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentTemperatureLabel.Location = new System.Drawing.Point(150, 67);
            this.CurrentTemperatureLabel.Name = "CurrentTemperatureLabel";
            this.CurrentTemperatureLabel.Size = new System.Drawing.Size(53, 25);
            this.CurrentTemperatureLabel.TabIndex = 4;
            this.CurrentTemperatureLabel.Text = "+t°C";
            // 
            // CurrentHumidityLabel
            // 
            this.CurrentHumidityLabel.AutoSize = true;
            this.CurrentHumidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentHumidityLabel.Location = new System.Drawing.Point(150, 92);
            this.CurrentHumidityLabel.Name = "CurrentHumidityLabel";
            this.CurrentHumidityLabel.Size = new System.Drawing.Size(43, 25);
            this.CurrentHumidityLabel.TabIndex = 5;
            this.CurrentHumidityLabel.Text = "h%";
            // 
            // CurrentPressureLabel
            // 
            this.CurrentPressureLabel.AutoSize = true;
            this.CurrentPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentPressureLabel.Location = new System.Drawing.Point(150, 117);
            this.CurrentPressureLabel.Name = "CurrentPressureLabel";
            this.CurrentPressureLabel.Size = new System.Drawing.Size(66, 25);
            this.CurrentPressureLabel.TabIndex = 6;
            this.CurrentPressureLabel.Text = "P mm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Humidity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pressure";
            // 
            // ChangeCityTextBox
            // 
            this.ChangeCityTextBox.Location = new System.Drawing.Point(20, 251);
            this.ChangeCityTextBox.Name = "ChangeCityTextBox";
            this.ChangeCityTextBox.Size = new System.Drawing.Size(183, 20);
            this.ChangeCityTextBox.TabIndex = 10;
            // 
            // ChangeCityButton
            // 
            this.ChangeCityButton.FlatAppearance.BorderSize = 0;
            this.ChangeCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeCityButton.Location = new System.Drawing.Point(209, 249);
            this.ChangeCityButton.Name = "ChangeCityButton";
            this.ChangeCityButton.Size = new System.Drawing.Size(101, 22);
            this.ChangeCityButton.TabIndex = 11;
            this.ChangeCityButton.Text = "Change city";
            this.ChangeCityButton.UseVisualStyleBackColor = true;
            this.ChangeCityButton.Click += new System.EventHandler(this.ChangeCityButton_Click);
            // 
            // CurrentWeatherPictureBox
            // 
            this.CurrentWeatherPictureBox.Image = global::WeatherPanelWinForms.Properties.Resources.night_half_moon_snow;
            this.CurrentWeatherPictureBox.Location = new System.Drawing.Point(316, 12);
            this.CurrentWeatherPictureBox.Name = "CurrentWeatherPictureBox";
            this.CurrentWeatherPictureBox.Size = new System.Drawing.Size(256, 256);
            this.CurrentWeatherPictureBox.TabIndex = 0;
            this.CurrentWeatherPictureBox.TabStop = false;
            this.CurrentWeatherPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Wind speed";
            // 
            // CurrentWindSpeedLabel
            // 
            this.CurrentWindSpeedLabel.AutoSize = true;
            this.CurrentWindSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentWindSpeedLabel.Location = new System.Drawing.Point(150, 142);
            this.CurrentWindSpeedLabel.Name = "CurrentWindSpeedLabel";
            this.CurrentWindSpeedLabel.Size = new System.Drawing.Size(89, 25);
            this.CurrentWindSpeedLabel.TabIndex = 13;
            this.CurrentWindSpeedLabel.Text = "V m/sec";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 283);
            this.Controls.Add(this.CurrentWindSpeedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeCityButton);
            this.Controls.Add(this.ChangeCityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentPressureLabel);
            this.Controls.Add(this.CurrentHumidityLabel);
            this.Controls.Add(this.CurrentTemperatureLabel);
            this.Controls.Add(this.CurrentCityLabel);
            this.Controls.Add(this.CurrentWeatherPictureBox);
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "WeatherPanel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeCity_keydown);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentWeatherPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CurrentWeatherPictureBox;
        private System.Windows.Forms.Label CurrentCityLabel;
        private System.Windows.Forms.Label CurrentTemperatureLabel;
        private System.Windows.Forms.Label CurrentHumidityLabel;
        private System.Windows.Forms.Label CurrentPressureLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ChangeCityTextBox;
        private System.Windows.Forms.Button ChangeCityButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentWindSpeedLabel;
    }
}

