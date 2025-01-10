using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Models.DTOs
{
    public class AuthorDTO
    {
        public int AuthorId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The Description must be between 1 and 100 characters.")]
        public required string Description { get; set; }
        public bool State { get; set; } = true;
    }
}
