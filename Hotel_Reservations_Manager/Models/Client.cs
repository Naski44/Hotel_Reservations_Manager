using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservations_Manager.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public bool Adult { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }
}
