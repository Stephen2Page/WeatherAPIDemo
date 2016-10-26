using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherAPIDemo.Models
{
    public class Weather
    {
        public Object getWeatherForcast()
        {
            string appid = "f9ef6ff16c06ec734352c3dab6dc88d5";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Cleveland&APPID=" + appid + "&units=imperial";
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }

    }
}