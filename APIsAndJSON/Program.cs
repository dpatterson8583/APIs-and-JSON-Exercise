using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    class Program
    {
        public static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            RonVSKanyeAPI QAPI = new RonVSKanyeAPI(client);

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"Kanye said:  {QAPI.GetKanyeQuote()}");

                Console.WriteLine($"Then Ron said: {QAPI.GetRonQuote()}");

            }

        }


    }
}