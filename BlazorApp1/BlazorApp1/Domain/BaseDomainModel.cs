namespace BlazorApp1.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
    }
}
