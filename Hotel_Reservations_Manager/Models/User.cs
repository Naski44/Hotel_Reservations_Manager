using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservations_Manager.Models
{
    public class User:IdentityUser
    {
        [Key]
        public Guid EGN {  get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateOnly HireDate { get; set; }
        public bool Active { get; set; }
        public DateOnly ?ReleaseDate { get; set; } = null;
    }
}
