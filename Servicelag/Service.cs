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
    public class Service
    {
        public string GetJson()
        {
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString(@"https://openexchangerates.org/api/latest.json?app_id=2d4606bf1f1949de88d88a2de69b0f78");

                CurrencyRate result = JsonConvert.DeserializeObject<CurrencyRate>(json);
                return json;
            }
        }
        
    }
}
