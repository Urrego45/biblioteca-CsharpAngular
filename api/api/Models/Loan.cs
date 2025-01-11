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
        public int UserId { get; set; }
        public User? User { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime ReturnConfirmDate { get; set; }
        public required string StateDelivered { get; set; }
        public required string StateReceived { get; set; }
        public bool State { get; set; }
        public DateTime CreationDate { get; } = DateTime.Now;

    }
}
