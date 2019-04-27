using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptModel
{
    public class CurrencyTransaction
    {
        public int Id { get; set; }

        public int CurrencyId { get; set; }

        public int TransactionId { get; set; }

        public int Count { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
