using Microsoft.EntityFrameworkCore;
using Hotel_Reservations_Manager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Hotel_Reservations_Manager.Data
{
    public class ApplicationDbContext:IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
