using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        public required string Description { get; set; }

        public bool State { get; set; } = true;

        public DateTime CreationDate { get; } = DateTime.Now;
    }
}
