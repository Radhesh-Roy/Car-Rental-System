using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalSystem.ModelConfiguaration;

public class CustomerConfiguaration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable(nameof(Customer));  
        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Name).HasMaxLength(50).IsRequired();
        builder.Property(x=>x.Email).HasMaxLength(100).IsRequired();
        builder.Property(x=>x.Password).HasMaxLength(100).IsRequired();
        builder.Property(x=>x.Address).HasMaxLength(200);
        builder.Property(x=>x.Phone).HasMaxLength(20);

    }
}
