using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WanderlustItinerary.Domain;

namespace WanderlustItinerary.Configurations.Entities
{
    public class PackageSeed : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasData(
                new Package
                {
                    Id = 1,
                    PackageName = "Japan Explorer",
                    Description = "7-day Tokyo & Kyoto tour",
                    Price = 2500m,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Package
                {
                    Id = 2,
                    PackageName = "Korea Highlights",
                    Description = "5-day Seoul & Busan tour",
                    Price = 1800m,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
