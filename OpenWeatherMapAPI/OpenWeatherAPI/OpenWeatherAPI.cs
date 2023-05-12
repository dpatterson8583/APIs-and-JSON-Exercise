// Reference data from OpenWeatherMap.org

//https://api.openweathermap.org/data/2.5/weather?q=Spring,us&APPID=dcc6efe1985afa5f97a91fed9329b002
//https://api.openweathermap.org/data/2.5/weather?q={city name},{state code},{country code}&appid={API key}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class OpenWeatherAPI
    {
        const string AppID = "XXXXXXXXXYXXXXXXXXXYXX";

        private HttpClient _client;
        
        public OpenWeatherAPI(HttpClient client) 
        {
            _client = client;
        }

        public string GetLocation()
        {
            string Location = "";           

            Console.Write("Enter your City name: > ");
            var City = Console.ReadLine();

            Console.Write("Enter your State abbreviation: > ");
            var State = Console.ReadLine();

            Console.Write("Enter your Country abbreviation: > ");
            var Country = Console.ReadLine();

            Location = City + "," + State + "," + Country;

            return Location;
        }

        public string GetWeatherData(string loc)
        {
            string mainobj = "";
            string curr_temperature = "";
            string weatherData = "";

            string wURL = "https://api.openweathermap.org/data/2.5/weather?q=" + loc + "&appid=" + AppID + "&units=imperial";
            weatherData = _client.GetStringAsync(wURL).Result;

            mainobj = JObject.Parse(weatherData).GetValue("main").ToString();
            curr_temperature = JObject.Parse(mainobj).GetValue("temp").ToString();

            return curr_temperature + "Fahrenheit";
        }
    }   
    
}
