using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public required string Description { get; set; }
        public bool State { get; set; } = true;
        public DateTime CreationDate { get; } = DateTime.Now;
    }
}
