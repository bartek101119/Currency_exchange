using Currency_exchange.Data;
using Currency_exchange.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Currency_exchange.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ICurrencyService _currencyService;
        private readonly ApplicationDbContext _context;

        public CurrencyController(ICurrencyService currencyService, ApplicationDbContext context)
        {
            _currencyService = currencyService;
            _context = context;
        }
        public IActionResult Index()
        {
            // change letter
            var currenciesResponse = _currencyService.Get("C");
            return View(currenciesResponse);
        }
    }
}
