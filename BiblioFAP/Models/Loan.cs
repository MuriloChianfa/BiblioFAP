using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BiblioFAP.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The loan need one book")]
        public Book Book { get; set; }

        [Required(ErrorMessage = "The loan need one customer")]
        public User Customer { get; set; }

        [Required(ErrorMessage = "The loan need one official")]
        public User Official { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime WithdrawnAt { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Giveback date is required")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime GiveBackAt { get; set; }
    }
}
