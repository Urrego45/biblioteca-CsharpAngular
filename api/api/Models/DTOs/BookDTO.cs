using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Models.DTOs
{
    public class BookDTO
    {
        public int? BookId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Cover is required.")]
        public required string Cover { get; set; }

        [Required(ErrorMessage = "Cover name is required.")]
        public required string CoverName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a Author.")]
        public int AuthorId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a category.")]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Required(ErrorMessage = "Description is required")]
        [MaxLength(150, ErrorMessage = "Location cannot exceed 100 characters")]
        public required string Location { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Copies is required.")]
        public int Copies { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public bool State { get; set; }
    }
}
