using BankruptModel;
using BankruptServiceDAL.BindingModel;
using BankruptServiceDAL.Interfaces;
using BankruptServiceDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceImplementDataBase.Implementations
{
    public class ProviderServiceDB : IProviderService
    {
        private BunkruptDbContext context;

        public ProviderServiceDB(BunkruptDbContext context)
        {
            this.context = context;
        }
        public void AddElement(ProviderBindingModel model)
        {
            Provider element = context.Providers.FirstOrDefault(rec => rec.ProviderFIO == model.ProviderFIO);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            context.Providers.Add(new Provider
            {
                ProviderFIO = model.ProviderFIO
            });
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Provider element = context.Providers.FirstOrDefault(rec => rec.Id == id);

            if (element != null)
            {
                context.Providers.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public ProviderViewModel GetElement(int id)
        {
            Provider element = context.Providers.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ProviderViewModel
                {
                    Id = element.Id,
                    ProviderFIO = element.ProviderFIO
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<ProviderViewModel> GetList()
        {
            List<ProviderViewModel> result = context.Providers.Select(rec => new ProviderViewModel
            {
                Id = rec.Id,
                ProviderFIO = rec.ProviderFIO
            })
            .ToList();
            return result;
        }

        public void UpdElement(ProviderBindingModel model)
        {
            Provider element = context.Providers.FirstOrDefault(rec => rec.ProviderFIO == model.ProviderFIO && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }

            element = context.Providers.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }

            element.ProviderFIO = model.ProviderFIO;
            context.SaveChanges();
        }
    }
}
