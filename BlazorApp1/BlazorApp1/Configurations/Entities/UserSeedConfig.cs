using BlazorApp1.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Configurations.Entities
{
    public class UserSeedConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id= "cfjd-y67e-4433-gyff-6fg5t-456yt-756jtu7",
                    Email="admin@localhost.com",
                    NormalizedEmail="ADMIN@LOCALHOST.COM",
                    FirstName="System",
                    LastName="Admin",
                    UserName= "admin@localhost.com",
                    NormalizedUserName="ADMIN@LOCALHOST.COM",
                    PasswordHash=hasher.HashPassword(null,"P@ssword1")
                },
                new ApplicationUser
                {
                    Id= "cfjd-y67e-4433-gyff-6fg5-456yt-756jtu7",
                    Email="user@localhost.com",
                    NormalizedEmail="USER@LOCALHOST.COM",
                    FirstName="System",
                    LastName = "System",
                    UserName = "user@localhost.com",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                }
            );
        }
    }
}
