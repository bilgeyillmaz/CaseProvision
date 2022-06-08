using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class CurrencyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI; database= CurrencyDb; integrated security=true");
        }
        public DbSet<CurrencyModel> CurrencyModels { get; set; }
        //public DbSet<Tarih_Date> Tarih_Dates { get; set; }
        //public DbSet<Tarih_DateCurrency> Tarih_DateCurrencies { get; set; }
    }
}
