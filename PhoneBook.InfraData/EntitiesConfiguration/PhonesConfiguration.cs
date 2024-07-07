using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Domain.Entities;

namespace PhoneBook.Infra.Data.Identity
{
    public class PhonesConfiguration : IEntityTypeConfiguration<PhoneEntity>
    {
        public void Configure(EntityTypeBuilder<PhoneEntity> builder)
        {
            //builder.HasKey(t => t.ContactId);
            //builder.Property(p => p.PhoneNumber).HasMaxLength(100).IsRequired();

            //builder.HasMany(p => p.Phones).WithOne().HasForeignKey(r => r.ContactId);

        }
    }
}
