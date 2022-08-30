using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_exchange.Models
{
    public class CurrencyResponse
    {
        public int Id { get; set; }
        public string Table { get; set; }
        public string No { get; set; }
        public string EffectiveDate { get; set; }
        public string TradingDate { get; set; }
        public List<Rate> Rates { get; set; } = new List<Rate>();
    }

    
}

