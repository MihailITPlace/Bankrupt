using BankruptModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.BindingModel
{
    public class TransactionBindingModel
    {
        public int Id { get; set; }

        public int RepositoryId { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime? DateImplement { get; set; }
    }
}
