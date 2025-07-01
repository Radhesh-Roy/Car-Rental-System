using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalSystem.ModelConfiguaration;

public class RentalConfiguaration : IEntityTypeConfiguration<Rental>
{
    public void Configure(EntityTypeBuilder<Rental> builder)
    {
        builder.ToTable(nameof(Rental));
        builder.HasKey(x => x.Id);
        builder.HasOne(x=>x.Customers).WithMany(x=>x.Rentals).HasForeignKey(x=>x.CustomerId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x=>x.Cars).WithMany(x=>x.Rentals).HasForeignKey(x=>x.CarId).OnDelete(DeleteBehavior.Restrict);
        builder.Property(x => x.RentDate);
        builder.Property(x=>x.ReturnDate);
        builder.Property(x=>x.Fine);
    }
}
