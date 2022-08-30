using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency_exchange.Models;

namespace Currency_exchange.Services.Interfaces
{
    public interface ICurrencyService
    {
        Task<List<CurrencyResponse>> Get(string table);
    }
}
