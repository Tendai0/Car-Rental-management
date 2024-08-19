using BlazorApp1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Configurations.Entities
{
    public class MakeSeedConfig : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id=1,
                    Name = "Toyota",
                    createdBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    updatedBy = "System",
                },
                new Make
                {
                    Id=2,
                    Name = "Mercedes-Benz",
                    createdBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    updatedBy = "System",
                }
            );
            
        }
    }
}
