using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalSystem.ModelConfiguaration;

public class CarsConfiguaration : IEntityTypeConfiguration<Cars>
{
    public void Configure(EntityTypeBuilder<Cars> builder)
    {
        builder.ToTable(nameof(Cars));  
        builder.HasKey(x=>x.Id);
        builder.Property(x => x.Brand).HasMaxLength(128).IsRequired();
        builder.Property(x => x.Model).HasMaxLength(128).IsRequired();
        builder.Property(x => x.NumberPlate).HasMaxLength(128).IsRequired();
        builder.Property(x => x.RentPerDay).HasMaxLength(128).IsRequired();
        builder.Property(x => x.IsAvailable);

    }
}
