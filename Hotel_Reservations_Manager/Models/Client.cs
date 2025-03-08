using Microsoft.AspNetCore.Identity;

namespace Hotel_Reservations_Manager.Models
{
    public class Client:IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Adult { get; set; }
    }
}
