using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "The email format is not valid.")]
        public string Email{ get; set; }
        public string Password { get; set; }
        public RolChoice Rol { get; set; } = RolChoice.lector;
        public bool State { get; set; }
        public DateTime CreationDate { get; } = DateTime.Now;

    }
}


public enum RolChoice
{
    empleado = 1,
    lector = 2,
}