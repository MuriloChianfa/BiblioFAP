using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioFAP.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "City name is required")]
        [MaxLength(255, ErrorMessage = "The name of city must be 255 characters only"), MinLength(1)]
        public string Name { get; set; }

        [ForeignKey("State")]
        [Required(ErrorMessage = "The state of city is required")]
        public int StateId { get; set; }
    }
}
