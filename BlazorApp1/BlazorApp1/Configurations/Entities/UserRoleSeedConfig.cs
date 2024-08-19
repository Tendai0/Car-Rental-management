using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Configurations.Entities
{
    public class UserRoleSeedConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(

                new IdentityUserRole<string>
                {
                    RoleId= "cfjfd-y676-4433-gyff-6g5t-456yt-756jtu7",
                    UserId= "cfjd-y67e-4433-gyff-6fg5-456yt-756jtu7"
                },
                new IdentityUserRole<string>
                {
                    RoleId= "cfjfd-y676e-4433-gyff-6fg5t-456yt-756jtu7",
                    UserId= "cfjd-y67e-4433-gyff-6fg5t-456yt-756jtu7"
                }
            );
        }
    }
}
