using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency_exchange.Models;
using Microsoft.EntityFrameworkCore;

namespace Currency_exchange.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<CurrencyResponse> Currencies { get; set; }
        public DbSet<Rate> Rates { get; set; }

    }
}
