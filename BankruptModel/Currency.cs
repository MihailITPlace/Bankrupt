using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptModel
{
    public class Currency
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("CurrencyId")]
        public virtual List<CurrencyTransaction> CurrencyTransactions { get; set; }

        [ForeignKey("CurrencyId")]
        public virtual List<CurrencyRepository> CurrencyRepositories { get; set; }
    }
}
