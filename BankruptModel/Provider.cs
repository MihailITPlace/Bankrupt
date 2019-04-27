﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptModel
{
    public class Provider
    {
        public int Id { get; set; }

        [Required]
        public string ProviderFIO { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        [ForeignKey("ProviderId")]
        public virtual List<Repository> Repositories { get; set; }
    }
}
