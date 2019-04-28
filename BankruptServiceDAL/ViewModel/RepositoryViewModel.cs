using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.ViewModel
{
    public class RepositoryViewModel
    {
        [DisplayName("Номер рпеозитория")]
        public int Id { get; set; }

        public int CurrencyId { get; set; }

        public int ProviderId { get; set; }
    }
}
