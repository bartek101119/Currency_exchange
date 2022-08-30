using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency_exchange.Services.Interfaces;

namespace Currency_exchange.Data
{
    public class CurrencySeeder
    {
        private readonly ApplicationDbContext _context;
        private readonly ICurrencyService _service;

        public CurrencySeeder(ApplicationDbContext context, ICurrencyService service)
        {
            _context = context;
            _service = service;
        }

        public async Task Seed()
        {
            if (await _context.Database.CanConnectAsync())
            {
                if (!_context.Currencies.Any())
                {
                    var currenciesResponseA = await _service.Get("A");
                    var currenciesResponseB = await _service.Get("B");
                    var currenciesResponseC = await _service.Get("C");
                    _context.Currencies.AddRange(currenciesResponseA);
                    _context.Currencies.AddRange(currenciesResponseB);
                    _context.Currencies.AddRange(currenciesResponseC);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
