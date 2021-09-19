using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BiblioFAP.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "CNPJ is required")]
        public string CNPJ { get; set; }

        public Address Address { get; set; }
    }
}
