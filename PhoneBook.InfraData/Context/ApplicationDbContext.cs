using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Entities;
using System.Reflection;
namespace PhoneBook.InfraData.Context
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<PhoneEntity> PhoneBook { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<PhoneEntity>().Property(p => p.Phones).HasMaxLength(100).IsRequired();


            modelBuilder.Entity<ContactEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<ContactEntity>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<ContactEntity>().Property(p => p.Age).IsRequired().HasMaxLength(3);

            modelBuilder.Entity<ContactEntity>().HasMany(p => p.Phones).WithOne().HasForeignKey(r => r.Id);
        }
    }
}
