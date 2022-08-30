using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Currency_exchange.Models;
using Currency_exchange.Services.Interfaces;
using Newtonsoft.Json;

namespace Currency_exchange.Services
{
    public class CurrencyService : ICurrencyService
    {
        public List<CurrencyResponse> Get(string table)
        {
            var url = $"http://api.nbp.pl/api/exchangerates/tables/{table}/";

            var web = new WebClient();

            var response = web.DownloadString(url);
            var myDeserializedClass = JsonConvert.DeserializeObject<List<CurrencyResponse>>(response);

            return myDeserializedClass;
        }
    }
}
