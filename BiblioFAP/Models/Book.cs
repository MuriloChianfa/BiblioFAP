using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioFAP.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Book name is required")]
        [MaxLength(255, ErrorMessage = "The name of book must be 3-255 characters only"), MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Book description is required")]
        [MaxLength(255, ErrorMessage = "The description of book must be 3-255 characters only"), MinLength(3)]
        public string Description { get; set; }

        [Required(ErrorMessage = "PageNumbers is required")]
        [Range(1, 10000, ErrorMessage = "The page number must be 1-10000 pages!")]
        public int PageNumbers { get; set; }

        [ForeignKey("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public int GenderId { get; set; }

        [ForeignKey("Publisher")]
        [Required(ErrorMessage = "Publisher is required")]
        public int PublisherId { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        public int TargetAudience { get; set; } = 0;

        [Range(1, 10000, ErrorMessage = "The book edition must be 1 between 1000!")]
        public int Edition { get; set; } = 1;

        [Range(1, 10000, ErrorMessage = "The book volumn must be 1 between 1000!")]
        public int Volumn { get; set; } = 1;

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime PublicatedAt { get; set; } = DateTime.Now;
    }
}
