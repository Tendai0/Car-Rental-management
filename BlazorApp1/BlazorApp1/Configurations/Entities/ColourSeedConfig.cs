using BlazorApp1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Configurations.Entities
{
    public class ColourSeedConfig : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(

                 new Colour
                 {
                     Id=1,
                     createdBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     Name = "Black",
                     updatedBy = "System"
                 },
                 new Colour
                 {
                     Id=2,
                     createdBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     Name = "Blue",
                     updatedBy = "System"
                 }
            );
        }
    }
}
