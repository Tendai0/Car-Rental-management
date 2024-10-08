﻿namespace BlazorApp1.Domain
{
    public class Customer:BaseDomainModel
    {
        public string TaxId { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}
