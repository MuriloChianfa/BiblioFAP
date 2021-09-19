using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioFAP.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(255, ErrorMessage = "The name must be 255 characters only"), MinLength(1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The E-mail is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [MaxLength(255, ErrorMessage = "The password must be 8-255 characters"), MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }

        [ForeignKey("AccessLevel")]
        public int AccessLevelId { get; set; } = 3;

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime BirthDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
