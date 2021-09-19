using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BiblioFAP.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Street is required")]
        [MaxLength(255, ErrorMessage = "The street must be 255 characters only"), MinLength(1)]
        public string Street { get; set; }

        [Required(ErrorMessage = "House id is required")]
        public string HouseId { get; set; }

        public City City { get; set; }
    }
}
