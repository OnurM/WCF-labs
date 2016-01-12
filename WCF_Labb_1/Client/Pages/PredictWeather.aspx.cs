using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.WeatherService;

namespace Client.Pages
{
    public partial class PredictWeather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPredictWeather_Click(object sender, EventArgs e)
        {
            WeatherService.WeatherSoapClient weatherService = new WeatherSoapClient();
            lblWeather.Text = weatherService.GetWeatherCondition();

        }
    }
}