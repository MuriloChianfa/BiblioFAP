using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioFAP.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(255, ErrorMessage = "The name must be 255 characters only"), MinLength(1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "CNPJ is required")]
        public string CNPJ { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
    }
}
