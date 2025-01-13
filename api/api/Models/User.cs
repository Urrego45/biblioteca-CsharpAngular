using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }

        public required string Email { get; set; }
        public required string Password { get; set; }

        // True = Empleado, False = Usuario
        public bool Rol { get; set; }
        public bool State { get; set; }
        public DateTime CreationDate { get; } = DateTime.Now;

    }
}
