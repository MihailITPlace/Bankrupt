using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.BindingModel
{
    public class CurrencyTransactionBindingModel
    {
        public int Id { get; set; }

        public int CurrencyId { get; set; }

        public int TransactionId { get; set; }

        public int Count { get; set; }
    }
}
