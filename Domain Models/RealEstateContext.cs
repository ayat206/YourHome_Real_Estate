using Microsoft.EntityFrameworkCore;

namespace Domain_Models;

public partial class RealEstateContext : DbContext
{
    public RealEstateContext()
    {
    }

    public RealEstateContext(DbContextOptions<RealEstateContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Choise> Choises { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-I5QC2RN\\SQLEXPRESS;Database=RealEstateHome;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Choise>(entity =>
        {
            entity.ToTable("Choise");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Choise1)
                .HasMaxLength(50)
                .HasColumnName("choise");
            // Seed data for Choise entity
            entity.HasData(
                new Choise { Id = 1, Choise1 = "Sell" },
                new Choise { Id = 2, Choise1 = "Rent" }
            );

        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.ToTable("Owner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contact)
                .HasMaxLength(50)
                .HasColumnName("contact");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("lastName");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.ToTable("Property");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Baths).HasColumnName("baths");
            entity.Property(e => e.ChoiseId).HasColumnName("choise-Id");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.OwnerId).HasColumnName("owner-Id");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.Rooms).HasColumnName("rooms");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.TypeId).HasColumnName("type-Id");

            entity.HasOne(d => d.Choise).WithMany(p => p.Properties)
                .HasForeignKey(d => d.ChoiseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Property_Choise");

            entity.HasOne(d => d.Owner).WithMany(p => p.Properties)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_Property_Owner");

            entity.HasOne(d => d.Type).WithMany(p => p.Properties)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Property_Type");
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.ToTable("Type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Type1)
                .HasMaxLength(100)
                .HasColumnName("type");
            // Seed data for Type entity
            entity.HasData(
                new Domain_Models.Type { Id = 1, Type1 = "Apartment" },
                new Domain_Models.Type { Id = 2, Type1 = "Villa" },
                new Domain_Models.Type { Id = 3, Type1 = "Home" },
                new Domain_Models.Type { Id = 4, Type1 = "Townhouse" },
                new Domain_Models.Type { Id = 5, Type1 = "Building" },
                new Domain_Models.Type { Id = 6, Type1 = "Office" }
            );
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
