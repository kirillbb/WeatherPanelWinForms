using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherPanelWinForms
{
    public partial class MainForm : Form
    {
        public string cityName = "Kharkiv";
        
        public MainForm()
        {
            InitializeComponent();


            SetCity();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        public void changeCityLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetCity();
        }
        private void SetCity()
        {
            if (ChangeCityTextBox.Text == "")
                WeatherResponse(cityName);
            else
                try
                {
                    WeatherResponse(ChangeCityTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void WeatherResponse(string cityName)
        {
            string url =
                $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&&lang=ru&appid=2f39c0029410e7ff9bd2b9d2b3228d8b";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            response = CleanJson(response);

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            CurrentCityLabel.Text = cityName.ToUpperInvariant();
            CurrentTemperatureLabel.Text = Convert.ToString(weatherResponse.Main.Temp) + "°C";
            CurrentHumidityLabel.Text = Convert.ToString(weatherResponse.Main.Humidity) + "%";
            CurrentPressureLabel.Text = Convert.ToString(weatherResponse.Main.Pressure) + " mmHg";
            CurrentWindSpeedLabel.Text = Convert.ToString(weatherResponse.Wind.Speed) + " m/sec";
            if(TimeOfDay(weatherResponse.Weather.Icon))
                WhatWeatherDay(weatherResponse.Weather.Id);
            else
                WhatWeatherNight(weatherResponse.Weather.Id);

        }

        private bool TimeOfDay(string icon)
        {
             return icon.Contains('d');
        }

        public void WhatWeatherDay(int id)
        {

            if (id < 800)
            {
                id = id / 100;

                switch (id)
                {
                    case 2:
                        CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.day_rain_thunder;
                        break;
                    case 5:
                        CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.day_rain;
                        break;
                    case 6:
                        CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.day_snow;
                        break;
                    default:
                        CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.day_clear;
                        break;
                }
            }
            else if (id == 800)
                CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.day_clear;
            else
                CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.day_partial_cloud;
        }
        public void WhatWeatherNight(int id)
        {

            if (id < 800)
            {
                id = id / 100;

                switch (id)
                {
                    case 2:
                        CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.night_half_moon_rain_thunder;
                        break;
                    case 5:
                        CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.night_half_moon_rain;
                        break;
                    case 6:
                        CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.night_half_moon_snow;
                        break;
                    default:
                        CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.night_half_moon_clear;
                        break;
                }
            }
            else if (id == 800)
                CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.night_half_moon_clear;
            else
                CurrentWeatherPictureBox.Image = WeatherPanelWinForms.Properties.Resources.night_half_moon_partial_cloud;
        }
        private static string CleanJson(string response)
        {
            response = response.Replace('[', ' ');
            response = response.Replace(']', ' ');

            return response;
        }

        private void ChangeCity_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                ChangeCityButton.PerformClick();
            }
        }

        private void ChangeCityButton_Click(object sender, EventArgs e)
        {
            SetCity();

            ChangeCityTextBox.Clear();
        }
    }
}
