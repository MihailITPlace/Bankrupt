using BankruptModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceImplementDataBase
{
    public class BunkruptDbContext : DbContext
    {
        public BunkruptDbContext() : base("BunkruptDb")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<Provider> Providers { get; set; }

        public virtual DbSet<Currency> Currencies { get; set; }

        public virtual DbSet<Repository> Repositories { get; set; }

        public virtual DbSet<Transaction> Transactions { get; set; }

        public virtual DbSet<CurrencyRepository> CurrencyRepositories { get; set; }

        public virtual DbSet<CurrencyTransaction> CurrencyTransactions { get; set; }
    }
}
