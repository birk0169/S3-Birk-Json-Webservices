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
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString(@"https://openexchangerates.org/api/latest.json?app_id=2d4606bf1f1949de88d88a2de69b0f78");

                CurrencyRate result = JsonConvert.DeserializeObject<CurrencyRate>(json);
                return result;
            }
        }
        
    }
}
