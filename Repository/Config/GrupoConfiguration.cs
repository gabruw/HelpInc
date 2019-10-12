using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(gru => gru.Id);
            builder.HasOne(gru => gru.GrupoPrestadorLider).WithMany().HasForeignKey(gru => gru.IdPrestadorLider);
            builder.HasMany(gru => gru.GrupoPrestador).WithOne(pre => pre.GrupoPrestador).HasForeignKey(pre => pre.Id);

            builder.HasIndex(gru => gru.Nome).IsUnique();
            builder.Property(gru => gru.Descricao).IsRequired().HasMaxLength(500).HasColumnType("varchar(500)");
            builder.Property(gru => gru.Imagem).IsRequired().HasMaxLength(1000).HasColumnType("varchar(1000)");
        }
    }
}