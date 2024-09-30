using Microsoft.EntityFrameworkCore;
using PropNexus.Entities.Models;

namespace PropNexus.RepositoryEF.Contexts;

public class PropNexusDBContext(DbContextOptions<PropNexusDBContext> options) : DbContext(options)
{
    public DbSet<Property> Properties { get; set; }
    public DbSet<Agent> Agents { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ListingStatus> ListingStatuses { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<PropertyTrace> PropertyTraces { get; set; }
    public DbSet<PropertyImage> PropertyImages { get; set; }

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
        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FirstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
            entity.Property(e => e.Email).IsRequired().IsUnicode(false);
            entity.Property(e => e.Phone).IsRequired();
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FirstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
            entity.Property(e => e.Email).IsRequired().IsUnicode(false);
            entity.Property(e => e.Phone).IsRequired();
        });

        modelBuilder.Entity<ListingStatus>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.StatusName).IsRequired().IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FirstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
            entity.Property(e => e.Email).IsRequired().IsUnicode(false);
            entity.Property(e => e.Phone).IsRequired();
        });

        modelBuilder.Entity<PropertyTrace>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.ListingDate).IsRequired();

            entity.HasOne<Agent>()
                .WithMany()
                .HasForeignKey(e => e.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne<Client>()
                .WithMany()
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne<ListingStatus>()
                .WithMany()
                .HasForeignKey(e => e.StatusId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<PropertyImage>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.ImageUrl).IsRequired().IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);

            entity.HasOne<Property>()
                .WithMany()
                .HasForeignKey(e => e.PropertyId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}