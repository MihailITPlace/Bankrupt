using BankruptServiceDAL.BindingModel;
using BankruptServiceDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.Interfaces
{
    public interface ITransactionService
    {
        List<TransactionViewModel> GetList();

        void CreateTransaction(TransactionViewModel model);

        void TakeTransactionInWork(TransactionViewModel model);

        void FinishTransaction(TransactionViewModel model);        

        void PutCurrencyOnRepository(CurrencyRepositoryBindingModel model);
    }
}
