using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.BindingModel
{
    public class RepositoryBindingModel
    {
        public int Id { get; set; }

        public int CurrencyId { get; set; }

        public int ProviderId { get; set; }
    }
}
