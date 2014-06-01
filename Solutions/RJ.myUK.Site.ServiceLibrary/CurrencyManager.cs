using RestSharp;

namespace RJ.myUK.Site.ServiceLibrary
{
    public class CurrencyManager : ICurrencyManager
    {
        private readonly RestClient _client;

        public CurrencyManager()
        {
            _client = new RestClient("http://rate-exchange.appspot.com");
        }

        public CurrencyExchangeRate GetExchangeRate()
        {
            var request = new RestRequest("currency", Method.GET);
            request.AddParameter("from", "EUR");
            request.AddParameter("to", "GBP");

            var response = _client.Execute<CurrencyExchangeRate>(request);
            return response.Data;
        }
    }
}
