using Microsoft.EntityFrameworkCore;
using PropNexus.Entities.Models;

namespace PropNexus.RepositoryEF.Contexts;

public class PropNexusDBContext(DbContextOptions<PropNexusDBContext> options) : DbContext(options)
{
    public DbSet<Property> Properties { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Property>(entity =>
        {
            entity.ToTable("properties");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address)
                .HasColumnName("address")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.City)
                .HasColumnName("city")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.State)
                .HasColumnName("state")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.ZipCode)
                .HasColumnName("zip_code")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.Price)
                .HasColumnName("price")
                .HasColumnType("decimal(10, 2)")
                .IsRequired();

            entity.Property(e => e.Bedrooms)
                .HasColumnName("bedrooms")
                .IsRequired();

            entity.Property(e => e.Bathrooms)
                .HasColumnName("bathrooms")
                .IsRequired();

            entity.Property(e => e.SquareFeet)
                .HasColumnName("square_feet")
                .IsRequired();

            entity.Property(e => e.PropertyType)
                .HasColumnName("property_type")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.Description)
                .HasColumnName("description")
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.OwnerId)
                .HasColumnName("owner_id");
        });
    }
}