using System.ComponentModel.DataAnnotations;

namespace BiblioFAP.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Gender name is required")]
        [MaxLength(255, ErrorMessage = "The name of gender must be 3-255 characters only"), MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender description is required")]
        [MaxLength(255, ErrorMessage = "The description of gender must be 3-255 characters only"), MinLength(3)]
        public string Description { get; set; }
    }
}
