using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        //False = Devuelto, True = Pendiente.
        public bool LoanState { get; set; } = false;
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime ReturnConfirmDate { get; set; }
        public string StateDelivered { get; set; }
        public string StateReceived { get; set; }
        public bool State { get; set; }
        public DateTime CreationDate { get; } = DateTime.Now;

    }
}
