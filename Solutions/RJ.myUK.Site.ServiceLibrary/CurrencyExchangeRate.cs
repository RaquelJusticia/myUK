using System;

namespace RJ.myUK.Site.ServiceLibrary
{
    public class CurrencyExchangeRate
    {
        public CurrencyExchangeRate()
        {
            Date = DateTime.Now;
        }

        public string From { get; set; }
        public double Rate { get; set; }
        public string To { get; set; }
        public DateTime Date { get; private set; } 
    }
}
