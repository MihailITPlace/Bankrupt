using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.ViewModel
{
    class CurrencyTransactionViewModel
    {
        public int Id { get; set; }

        public int CurrencyId { get; set; }

        [DisplayName("Номер транзакции")]
        public int TransactionId { get; set; }

        [DisplayName("Количество валюты")]
        public int Count { get; set; }
    }
}
