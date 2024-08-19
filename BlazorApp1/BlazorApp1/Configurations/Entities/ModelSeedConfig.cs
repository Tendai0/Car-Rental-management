using BlazorApp1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Configurations.Entities
{
    public class ModelSeedConfig : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
               new Model
               {
                   Id = 1,
                   DateCreated = DateTime.UtcNow,
                   createdBy = "System",
                   DateUpdated = DateTime.UtcNow,
                   Name = "Vitz",
                   updatedBy = "System",
               },
                new Model
                {
                    Id= 2,
                    DateCreated = DateTime.UtcNow,
                    createdBy = "System",
                    DateUpdated = DateTime.UtcNow,
                    Name = "fit",
                    updatedBy = "System",
                },
                 new Model
                 {
                     Id=3,
                     DateCreated = DateTime.UtcNow,
                     createdBy = "System",
                     DateUpdated = DateTime.UtcNow,
                     Name = "Volvo",
                     updatedBy = "System",
                 }
            );
        }
    }
}
