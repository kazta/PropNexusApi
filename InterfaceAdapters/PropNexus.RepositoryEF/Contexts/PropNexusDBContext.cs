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
            entity.ToTable("agents");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FirstName)
                .HasColumnName("first_name")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.LastName)
                .HasColumnName("last_name")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.Email)
                .HasColumnName("email")
                .IsRequired()
                .HasMaxLength(int.MaxValue)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasColumnName("phone")
                .IsRequired()
                .HasMaxLength(int.MaxValue);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("clients");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FirstName)
                .HasColumnName("first_name")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.LastName)
                .HasColumnName("last_name")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.Email)
                .HasColumnName("email")
                .IsRequired()
                .HasMaxLength(int.MaxValue)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasColumnName("phone")
                .IsRequired()
                .HasMaxLength(int.MaxValue);
        });

        modelBuilder.Entity<ListingStatus>(entity =>
        {
            entity.ToTable("listing_statuses");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatusName)
                .HasColumnName("status_name")
                .IsRequired()
                .HasMaxLength(int.MaxValue)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("description")
                .HasMaxLength(int.MaxValue)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.ToTable("owners");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FirstName)
                .HasColumnName("first_name")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.LastName)
                .HasColumnName("last_name")
                .IsRequired()
                .HasMaxLength(int.MaxValue);

            entity.Property(e => e.Email)
                .HasColumnName("email")
                .IsRequired()
                .HasMaxLength(int.MaxValue)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasColumnName("phone")
                .IsRequired()
                .HasMaxLength(int.MaxValue);
        });

        modelBuilder.Entity<PropertyTrace>(entity =>
        {
            entity.ToTable("property_trace");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ListingDate)
                .HasColumnName("listing_date")
                .IsRequired();

            entity.Property(e => e.PropertyId)
                .HasColumnName("property_id");

            entity.Property(e => e.AgentId)
                .HasColumnName("agent_id");

            entity.Property(e => e.ClientId)
                .HasColumnName("client_id");

            entity.Property(e => e.StatusId)
                .HasColumnName("status_id");

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
            entity.ToTable("property_images");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ImageUrl)
                .HasColumnName("image_url")
                .IsRequired()
                .HasMaxLength(int.MaxValue)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("description")
                .HasMaxLength(int.MaxValue)
                .IsUnicode(false);

            entity.Property(e => e.PropertyId)
                .HasColumnName("property_id");

            entity.HasOne<Property>()
                .WithMany()
                .HasForeignKey(e => e.PropertyId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}