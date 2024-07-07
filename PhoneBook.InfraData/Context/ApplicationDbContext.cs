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
            .HasOne(t => t.Contact)          
            .WithMany(c => c.Phones)       
            .HasForeignKey(t => t.ContactId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PhoneEntity>().HasKey(t => t.PhoneId);

            modelBuilder.Entity<ContactEntity>().HasKey(t => t.ContactId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
