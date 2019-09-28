using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class HabilidadeConfiguration : IEntityTypeConfiguration<Habilidade>
    {
        public void Configure(EntityTypeBuilder<Habilidade> builder)
        {
            builder.HasKey(hab => hab.Id);

            builder.Property(hab => hab.Nivel).IsRequired().HasMaxLength(1).HasColumnType("char(1)");
            builder.Property(hab => hab.Descricao).HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(hab => hab.ValorBase).IsRequired().HasMaxLength(15).HasColumnType("bigint(15)");
        }
    }
}