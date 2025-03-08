using Hotel_Reservations_Manager.Models;
namespace Hotel_Reservations_Manager.Models
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public List<Client> Clients { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public bool BreakfastIncluded { get; set; }
        public bool AllInclusive { get; set; }
        public double FinalPrice { get; set; }
    }
}
