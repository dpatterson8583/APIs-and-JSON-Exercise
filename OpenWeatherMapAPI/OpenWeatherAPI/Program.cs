using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    class Program
    {
        public static void Main(string[] args)
        {
            string temp = "";

            HttpClient client = new HttpClient();
            OpenWeatherAPI OAPI = new OpenWeatherAPI(client);

            

            temp = OAPI.GetWeatherData(OAPI.GetLocation());

            Console.WriteLine(temp);

        }


    }
}