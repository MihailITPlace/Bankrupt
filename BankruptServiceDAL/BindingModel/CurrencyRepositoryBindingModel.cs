using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.BindingModel
{
    public class CurrencyRepositoryBindingModel
    {
        public int Id { get; set; }

        public int CurrencyId { get; set; }

        public int RepositoryId { get; set; }

        public int Count { get; set; }
    }
}
