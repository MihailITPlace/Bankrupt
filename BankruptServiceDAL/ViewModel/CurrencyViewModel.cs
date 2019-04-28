using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.ViewModel
{
    public class CurrencyViewModel
    {
        public int Id { get; set; }

        [DisplayName("Наименование валюты")]
        public string Name { get; set; }
    }
}
