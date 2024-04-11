using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPasswordManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswordManager.Persistence.Configurations
{
    internal class PasswordConfiguration : IEntityTypeConfiguration<Password>
    {
        public void Configure(EntityTypeBuilder<Password> builder)
        {
            builder.Property(x=>x.EncryptedPassword).IsRequired();
            builder.Property(x=>x.SiteId).IsRequired();
            builder.Property(x=>x.Description).HasMaxLength(100).IsRequired(false).HasColumnType("text");
        }
    }
}
