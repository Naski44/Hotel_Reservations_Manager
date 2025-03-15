using Hotel_Reservations_Manager.Models;
using System.ComponentModel.DataAnnotations;
namespace Hotel_Reservations_Manager.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public int RoomNumber { get; set; }
        public Room Room { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<Client> Clients = new List<Client>();
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool BreakfastIncluded { get; set; }
        public bool AllInclusive { get; set; }
        public double FinalPrice { get; set; }
    }
}
