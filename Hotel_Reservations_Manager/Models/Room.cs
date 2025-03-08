using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservations_Manager.Models
{
    public class Room
    {
        [Key]
        public int RoomdNumber { get; set; }
        public int Capacity { get; set; }
        public enum Type{two_single_beds,apartment,double_bed,penthouse,maissonette} 
        public bool IsAvailable { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }
    }
}
