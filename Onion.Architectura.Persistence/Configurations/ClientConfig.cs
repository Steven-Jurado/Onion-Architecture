using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Architecture.Domain.Entities;

namespace Onion.Architectura.Persistence.Configurations
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(x => x.BornDate)
               .IsRequired();

            builder.Property(x => x.Telephone)
               .HasMaxLength(9)
               .IsRequired();

            builder.Property(x => x.Email)
               .HasMaxLength(100);

            builder.Property(x => x.Address)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(x => x.Age);

            builder.Property(x => x.CreatedBy)
              .HasMaxLength(30);

            builder.Property(x => x.LastModifiedBy)
              .HasMaxLength(30);
        }
    }
}
