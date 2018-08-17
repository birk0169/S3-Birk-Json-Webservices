using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entiteter;
using Newtonsoft.Json;
using System.Net;

namespace Servicelag
{
    /// <summary>
    /// Gets currency date from API
    /// </summary>
    public class CurrencyService
    {
        /// <summary>
        /// Gets the currency data from the API and returns them in the form of a CurrencyRate object
        /// </summary>
        /// <returns>
        /// CurrencyRate Object
        /// </returns>
        public CurrencyRate GetCurrencyData()
        {
            //using (WebClient webClient = new WebClient())
            //{
            //    string json = webClient.DownloadString(@"https://openexchangerates.org/api/latest.json?app_id=2d4606bf1f1949de88d88a2de69b0f78");

            //    CurrencyRate result = JsonConvert.DeserializeObject<CurrencyRate>(json);
            //    return result;
            //}
            
            return GetGenericDataFromJson<CurrencyRate>("https://openexchangerates.org/api/latest.json?app_id=2d4606bf1f1949de88d88a2de69b0f78");
        }

        ///// <summary>
        ///// Gets the weather data from the API and returns them in the form of a WeatherData object doesn't work at the moment
        ///// </summary>
        ///// <returns>
        ///// WeatherData object</returns>
        //public WeatherData GetWeatherData()
        //{
        //    return GetGenericDataFromJson<WeatherData>("http://api.openweathermap.org/data/2.5/forecast?q=London&mode=json&units=metric&APPID=098ea01b34673a2948c893da06c6424c;");
        //}

        /// <summary>
        /// Gets the nasa data from the API and returns it in the form of a NasaData object
        /// </summary>
        /// <returns>
        /// NasaData object
        /// </returns>
        public NasaData GetNasaData()
        {
            return GetGenericDataFromJson<NasaData>("https://api.nasa.gov/planetary/apod?api_key=NNKOjkoul8n1CH18TWA9gwngW1s1SmjESPjNoUFo");
        }

        /// <summary>
        /// Returns the ip adresse of the computer it is called on, from its API
        /// </summary>
        /// <returns>MyIpAdresse object</returns>
        public MyIpAdresse GetMyIpAdresse()
        {
            return GetGenericDataFromJson<MyIpAdresse>("http://ip.jsontest.com/");
        }
        
        /// <summary>
        /// Loads JSON data from a online API and coverts it to a class opject based on input
        /// </summary>
        /// <typeparam name="The type of element is generic class object"></typeparam>
        /// <param name="url"></param>
        /// <returns>
        /// Class object
        /// </returns>
        private static T GetGenericDataFromJson<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                //Try downloading JSON data as string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception){}

                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
        
    }
}
