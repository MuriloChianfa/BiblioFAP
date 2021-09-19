using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioFAP.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Book")]
        [Required(ErrorMessage = "The loan need one book")]
        public int BookId { get; set; }

        [ForeignKey("User")]
        [Required(ErrorMessage = "The loan need one customer")]
        public int CustomerId { get; set; }

        [ForeignKey("User")]
        [Required(ErrorMessage = "The loan need one official")]
        public int OfficialId { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime WithdrawnAt { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Giveback date is required")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime GiveBackAt { get; set; }
    }
}
