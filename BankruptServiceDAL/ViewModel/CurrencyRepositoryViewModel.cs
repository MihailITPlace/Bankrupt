using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.ViewModel
{
    class CurrencyRepositoryViewModel
    {
        public int Id { get; set; }

        public int CurrencyId { get; set; }

        [DisplayName("Номер репозитория")]
        public int RepositoryId { get; set; }

        [DisplayName("Количество валюты")]
        public int Count { get; set; }
    }
}
