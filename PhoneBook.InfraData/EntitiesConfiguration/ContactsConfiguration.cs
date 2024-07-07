using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Infra.Data.EntitiesConfiguration
{
    public class ContactsConfiguration : IEntityTypeConfiguration<ContactEntity>
    {
        public void Configure(EntityTypeBuilder<ContactEntity> builder)
        {
            //builder.HasKey(t => t.ContactId);
            //builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            //builder.Property(p => p.Age).IsRequired().HasMaxLength(3);

        }
    }

}

