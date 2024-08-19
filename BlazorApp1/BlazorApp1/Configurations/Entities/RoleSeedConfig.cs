using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Configurations.Entities
{
    public class RoleSeedConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id="cfjfd-y676-4433-gyff-6g5t-456yt-756jtu7",
                    Name = "User",
                    NormalizedName="USER"
                },
                new IdentityRole
                {
                    Id= "cfjfd-y676e-4433-gyff-6fg5t-456yt-756jtu7",
                    Name ="Administrator",
                    NormalizedName="ADMINISTRATOR"
                }
            );
        }
    }
}
