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
            builder.HasOne(gru => gru.GrupoPrestador).WithMany().HasForeignKey(pre => pre.GrupoPrestador);
            builder.HasKey(gru => gru.IdPrestadorLider);
            builder.HasIndex(gru => gru.Nome).IsUnique();
            builder.Property(gru => gru.Descricao).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(gru => gru.Imagem).IsRequired().HasMaxLength(1).HasColumnType("varchar(40)");




           


        }
    }
}