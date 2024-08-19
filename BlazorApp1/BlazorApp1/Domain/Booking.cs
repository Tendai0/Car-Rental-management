namespace BlazorApp1.Domain
{
   
    public class Booking : BaseDomainModel
    {
        public virtual Vehicle Vehicles { get; set; }
        public int VehicleId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public virtual Customer Customers { get; set; }
        public int CustomerId { get; set; }
       
    }
}
