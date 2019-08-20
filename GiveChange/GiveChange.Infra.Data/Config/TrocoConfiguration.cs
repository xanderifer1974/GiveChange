using GiveChange.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GiveChange.Infra.Data.Config
{
    public class TrocoConfiguration : IEntityTypeConfiguration<Troco>
    {
        public void Configure(EntityTypeBuilder<Troco> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.NomeProduto)
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(t => t.PrecoProduto)
           .IsRequired();

            builder.Property(t => t.ValorPago)
            .IsRequired();

            builder.Property(t => t.ValorTroco);
        }
    }
}
