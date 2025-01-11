using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public required string Title { get; set; }
        public required string Cover { get; set; }
        public required string CoverName { get; set; }
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public required string Location { get; set; }
        public int Copies { get; set; }
        public bool State { get; set; }
        public DateTime CreationDate { get; } = DateTime.Now;
    }
}
