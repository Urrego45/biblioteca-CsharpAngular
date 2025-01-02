using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The Description must be between 1 and 100 characters.")]
        public required string Description { get; set; }

        [Column(TypeName = "bit")]
        public bool State { get; set; } = true;

        [Column(TypeName = "datetime2")]
        public DateTime CreationDate { get; } = DateTime.Now;
    }
}
