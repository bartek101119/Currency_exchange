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

        public void Seed()
        {
            if (_context.Database.CanConnect())
            {
                if (!_context.Currencies.Any())
                {
                    var currenciesResponseA = _service.Get("A");
                    var currenciesResponseB = _service.Get("B");
                    var currenciesResponseC = _service.Get("C");
                    _context.Currencies.AddRange(currenciesResponseA);
                    _context.Currencies.AddRange(currenciesResponseB);
                    _context.Currencies.AddRange(currenciesResponseC);
                    _context.SaveChanges();
                }
            }
        }
    }
}
