using BankruptServiceDAL.BindingModel;
using BankruptServiceDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.Interfaces
{
    public interface IRepositoryService
    {
        List<RepositoryViewModel> GetList();

        RepositoryViewModel GetElement(int id);

        void AddElement(RepositoryBindingModel model);

        void UpdElement(RepositoryBindingModel model);

        void DelElement(int id);
    }
}
