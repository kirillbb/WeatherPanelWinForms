using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherPanelWinForms
{
    public class WeatherResponse
    {
        public WeatherInfo Weather { get; set; }
        public WeatherMainInfo Main { get; set; }
        public WindInfo Wind { get; set; }

        public string Name { get; set; }
    }
}
