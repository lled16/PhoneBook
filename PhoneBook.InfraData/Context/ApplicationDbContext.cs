using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Entities;
using System.Reflection;
namespace PhoneBook.InfraData.Context
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<PhoneEntity> Telefones { get; set; }
        public DbSet<ContactEntity> Contatos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneEntity>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<PhoneEntity>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd(); // Configuração para auto incremento

            modelBuilder.Entity<PhoneEntity>()
                .Property(p => p.Phones)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<PhoneEntity>()
                .HasOne(p => p.Contact)
                .WithMany(c => c.Phones)
                .HasForeignKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ContactEntity>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<ContactEntity>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd(); // Configuração para auto incremento

            modelBuilder.Entity<ContactEntity>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<ContactEntity>()
                .Property(c => c.Age)
                .IsRequired()
                .HasMaxLength(3);

            modelBuilder.Entity<ContactEntity>()
                .HasMany(c => c.Phones)
                .WithOne(p => p.Contact)
                .HasForeignKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
