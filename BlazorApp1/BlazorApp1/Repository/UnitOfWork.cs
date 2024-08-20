using BlazorApp1.Data;
using BlazorApp1.Domain;
using BlazorApp1.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private  IGenericRepsitory<Make> _makes;
        private IGenericRepsitory<Model> _model;
        private IGenericRepsitory<Vehicle> _vehicle;
        private IGenericRepsitory<Booking> _bookings;
        private IGenericRepsitory<Customer> _customers;
        private IGenericRepsitory<Colour> _colour;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IGenericRepsitory<Make> Makes => _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepsitory<Model> Models => _model ??= new GenericRepository<Model>(_context);
        public IGenericRepsitory<Vehicle> Vehicles => _vehicle ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepsitory<Booking> Bookings => _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepsitory<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepsitory<Colour> Colour => _colour ??= new GenericRepository<Colour>(_context);

        public void Dispose()
        {
           _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user =httpContext.User.Identity.Name;
            var entries = _context.ChangeTracker.Entries().Where(q => q.State == Microsoft.EntityFrameworkCore.EntityState.Modified ||
            q.State ==EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).updatedBy =user;
                if(entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).createdBy = user;
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
