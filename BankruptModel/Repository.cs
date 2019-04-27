using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptModel
{
    public class Repository
    {
        public int Id { get; set; }

        public int CurrencyId { get; set; }

        public int ProviderId { get; set; }

        public virtual Provider Provider { get; set; }

        [ForeignKey("RepositoryId")]
        public virtual List<CurrencyRepository> CurrencyRepositories { get; set; }

        [ForeignKey("RepositoryId")]
        public virtual List<Transaction> Transactions { get; set; }
    }
}
