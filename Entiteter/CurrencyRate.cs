using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteter
{
    /// <summary>
    /// This class contains currency data in the form of Disclaimers(string), Lincense(string), Timestamp(long), Base(string) and Rates(Dictionary<string decimal>)
    /// </summary>
    public class CurrencyRate
    {
        private string _base;

        //Properties
        /// <summary>
        /// Holds the disclaimer note from the API
        /// </summary>
        public string Disclaimer { get; set; }
        /// <summary>
        /// Holds the lincense note from the API
        /// </summary>
        public string License { get; set; }
        /// <summary>
        /// Holds the timestamp from the API
        /// </summary>
        public long Timestamp { get; set; }
        /// <summary>
        /// Holds the information of what base the currency is set on, this must always be USD and if its anything else it will thow an Exception
        /// </summary>
        public string Base
        {
            get => _base;
            set
            {
                if (value == "USD")
                {
                    _base = value;
                }
                else
                {
                    throw new ArgumentException("Base is not USD");
                }
                
            }
        }
        /// <summary>
        /// Holds the data about the currency rates and their keys based on the currency base
        /// </summary>
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
