using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WanderlustItinerary.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var admin = new IdentityUser
            {
                Id = "ADMIN-001",
                UserName = "admin@wanderlust.com",
                NormalizedUserName = "ADMIN@WANDERLUST.COM",
                Email = "admin@wanderlust.com",
                NormalizedEmail = "ADMIN@WANDERLUST.COM",
                EmailConfirmed = true
            };

            admin.PasswordHash = hasher.HashPassword(admin, "Admin123!");
            builder.HasData(admin);
        }
    }
}
