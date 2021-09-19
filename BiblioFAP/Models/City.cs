using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BiblioFAP.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "City name is required")]
        [MaxLength(255, ErrorMessage = "The name of city must be 255 characters only"), MinLength(1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The state of city is required")]
        public State State { get; set; }
    }
}
