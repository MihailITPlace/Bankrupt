using BankruptServiceDAL.BindingModel;
using BankruptServiceDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.Interfaces
{
    public interface ICurrencyService
    {
        List<CurrencyViewModel> GetList();

        CurrencyViewModel GetElement(int id);

        void AddElement(CurrencyBindingModel model);

        void UpdElement(CurrencyBindingModel model);

        void DelElement(int id);
    }
}
