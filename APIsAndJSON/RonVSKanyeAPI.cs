using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        private HttpClient _http;

        public RonVSKanyeAPI(HttpClient http)
        {
            _http = http;
        }

        public string GetKanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string GetRonQuote()
        {
            var client = new HttpClient();
            var ronURL = " https://ron-swanson-quotes.herokuapp.com/v2/quotes/";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronQuote;
        }




 


  
    }
}
