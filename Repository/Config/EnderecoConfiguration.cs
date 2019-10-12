using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(end => end.Id);

            builder.Property(end => end.Cep).IsRequired(true).HasMaxLength(8).HasColumnType("int(8)");
            builder.Property(end => end.Rua).IsRequired(true).HasMaxLength(80).HasColumnType("varchar(80)");
            builder.Property(end => end.Bairro).IsRequired(true).HasMaxLength(80).HasColumnType("varchar(60)");
            builder.Property(end => end.Numero).IsRequired(true).HasMaxLength(5).HasColumnType("int(5)");
            builder.Property(end => end.Complemento).HasMaxLength(5).HasColumnType("int(5)");
            builder.Property(end => end.Cidade).IsRequired(true).HasMaxLength(80).HasColumnType("varchar(80)");
            builder.Property(end => end.Estado).IsRequired(true).HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(end => end.Referencia).HasMaxLength(100).HasColumnType("varchar(100)");
        }
    }
}