using System.ComponentModel.DataAnnotations;

namespace BiblioFAP.Models
{
    public class AccessLevel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "AccessLevel name is required")]
        [MaxLength(255, ErrorMessage = "The name must be 255 characters only"), MinLength(1)]
        public string Name { get; set; }
    }
}
