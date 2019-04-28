using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptServiceDAL.ViewModel
{
    public class PoviderViewModel
    {
        public int Id { get; set; }

        [DisplayName("ФИО поставщика")]
        public string ProviderFIO { get; set; }

        [DisplayName("Email поставщика")]
        public string Email { get; set; }

        public string PasswordHash { get; set; }
    }
}
