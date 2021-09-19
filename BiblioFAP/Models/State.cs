using System.ComponentModel.DataAnnotations;

namespace BiblioFAP.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "State name is required")]
        [MaxLength(255, ErrorMessage = "The name of state must be 255 characters only"), MinLength(1)]
        public string Name { get; set; }

        [MaxLength(2, ErrorMessage = "The UF of state must be 2 characters only"), MinLength(2)]
        public string UF { get; set; }
    }
}
