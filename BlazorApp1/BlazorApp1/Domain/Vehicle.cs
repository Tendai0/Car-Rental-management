namespace BlazorApp1.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
        public virtual Colour colour { get; set; }
        public int ColourId { get; set; }
        public string Vin { get; set; }
        public string LicencePlateNumber { get; set; }
        public double RentalRate { get; set; }
        public virtual List<Booking> Bookings  { get; set; }
    }
}
