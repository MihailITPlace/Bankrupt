using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptModel
{
    public class Transaction
    {
        public int Id { get; set; }

        public int RepositoryId { get; set; }

        public TransactionStatus Status { get; set; }

        [ForeignKey("TransactionId")]
        public virtual List<CurrencyTransaction> CurrencyTransactions { get; set; }
    }
}
