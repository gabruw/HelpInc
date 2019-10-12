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
            builder.HasOne(hab => hab.PrestadorHabilidade).WithMany(pre => pre.HabilidadePrestador).HasForeignKey(hab => hab.IdPrestador);

            builder.Property(hab => hab.Nivel).IsRequired(true).HasMaxLength(1).HasColumnType("char(1)");
            builder.Property(hab => hab.Descricao).HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(hab => hab.ValorBase).IsRequired(true).HasMaxLength(15).HasColumnType("bigint(15)");
        }
    }
}