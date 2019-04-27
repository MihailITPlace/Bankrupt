using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptModel
{
    public class CurrencyRepository
    {
        public int Id { get; set; }

        public int CurrencyId { get; set; }

        public int RepositoryId { get; set; }

        public int Count { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Repository Repository { get; set; }
    }
}
