using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.BindingModel
{
    public class ProviderBindingModel
    {
        public int Id { get; set; }
        
        public string ProviderFIO { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }        
    }
}
