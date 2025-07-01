using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalSystem.ModelConfiguaration;

public class AdminConfiguaration : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.ToTable(nameof(Admin)); 
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(50);
        builder.Property(x=>x.Email).HasMaxLength(50).IsRequired();
        builder.Property(x=>x.Phone).HasMaxLength(50);
        builder.Property(x=>x.Password).HasMaxLength(50).IsRequired();
    }
}
