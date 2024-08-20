using BlazorApp1.Domain;

namespace BlazorApp1.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        Task  Save(HttpContext httpContext);
        IGenericRepsitory<Make> Makes { get; }
        IGenericRepsitory<Model> Models { get; }
        IGenericRepsitory<Vehicle> Vehicles { get; }
        IGenericRepsitory<Booking> Bookings { get; }
        IGenericRepsitory<Customer> Customers { get; }
        IGenericRepsitory<Colour> Colour { get; }
    }
}
