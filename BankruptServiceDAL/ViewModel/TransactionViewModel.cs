using BankruptModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.ViewModel
{
    public class TransactionViewModel
    {
        [DisplayName("Номер транзакции")]
        public int Id { get; set; }

        public int RepositoryId { get; set; }

        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }

        [DisplayName("Дата выполнения")]
        public DateTime? DateImplement { get; set; }

        [DisplayName("Статус")]
        public TransactionStatus Status { get; set; }
    }
}
