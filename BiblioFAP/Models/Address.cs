using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("City")]
        public int CityId { get; set; }
    }
}
