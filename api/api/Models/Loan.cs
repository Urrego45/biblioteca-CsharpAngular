using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        //False = Devuelto, True = Pendiente.
        public bool LoanState { get; set; } = false;

        [Range(1, int.MaxValue, ErrorMessage = "Please select a category.")]
        public int UserId { get; set; }
        public User? User { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a category.")]
        public int BookId { get; set; }
        public Book? Book { get; set; }

        public DateTime ReturnDate { get; set; }
        public DateTime ReturnConfirmDate { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Required(ErrorMessage = "State delivered is required.")]
        public required string StateDelivered { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Required(ErrorMessage = "State Received is required.")]
        public required string StateReceived { get; set; }

        public bool State { get; set; }
        public DateTime CreationDate { get; } = DateTime.Now;

    }
}
