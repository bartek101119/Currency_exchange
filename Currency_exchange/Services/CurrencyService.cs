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
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public CurrencyService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<List<CurrencyResponse>> Get(string table)
        {
            var nbpUrl = _configuration.GetSection("MyUrl").GetSection("NbpUrl").Value;
            var url = $"{nbpUrl}{table}";

            var client = _httpClientFactory.CreateClient();

            var response = await client.GetStringAsync(url);
            var myDeserializedClass = JsonConvert.DeserializeObject<List<CurrencyResponse>>(response);
            return myDeserializedClass;

        }
    }
}
