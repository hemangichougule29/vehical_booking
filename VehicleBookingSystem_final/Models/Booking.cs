namespace VehicleBookingSystem.Models
{
    public class Booking
    {
        public string CustomerName { get; set; }
        public string PickupLocation { get; set; }
        public string DropLocation { get; set; }
        public string VehicleType { get; set; }
        public double Distance { get; set; }
        public double Price { get; set; }
    }
}
