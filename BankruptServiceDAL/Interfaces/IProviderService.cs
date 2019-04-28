using BankruptServiceDAL.BindingModel;
using BankruptServiceDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.Interfaces
{
    public interface IProviderService
    {
        List<PoviderViewModel> GetList();

        PoviderViewModel GetElement(int id);

        void AddElement(ProviderBindingModel model);

        void UpdElement(ProviderBindingModel model);

        void DelElement(int id);
    }
}
