using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Domain.Entities;

namespace PhoneBook.Infra.Data.Identity
{
    public class PhonesConfiguration : IEntityTypeConfiguration<PhoneEntity>
    {
        public void Configure(EntityTypeBuilder<PhoneEntity> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Phones).HasMaxLength(100).IsRequired();

        }
    }
}
