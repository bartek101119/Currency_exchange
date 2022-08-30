using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_exchange.Models
{
    public class Rate
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }
        public double Mid { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
        public CurrencyResponse CurrencyResponse { get; set; }
        public int CurrencyResponseId { get; set; }
    }
}
