using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WanderlustItinerary.Configurations.Entities;
using WanderlustItinerary.Domain;

namespace WanderlustItinerary.Data
{
    public class WanderlustItineraryContext : IdentityDbContext<IdentityUser>
    {
        public WanderlustItineraryContext(DbContextOptions<WanderlustItineraryContext> options)
            : base(options)
        {
        }

        // Domain tables
        public DbSet<Booking> Booking { get; set; } = default!;
        public DbSet<Package> Package { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
         
            base.OnModelCreating(builder);

           
            builder.Entity<Booking>()
                .HasOne(b => b.Package)
                .WithMany()
                .HasForeignKey(b => b.PackageId);

            // Domain seed
            builder.ApplyConfiguration(new PackageSeed());

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
