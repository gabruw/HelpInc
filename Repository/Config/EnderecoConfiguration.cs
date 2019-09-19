using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(en => en.Id);

            builder.Property(en => en.Cep).IsRequired().HasMaxLength(8).HasColumnType("int(8)");
            builder.Property(en => en.Rua).IsRequired().HasMaxLength(80).HasColumnType("varchar(80)");
            builder.Property(en => en.Bairro).IsRequired().HasMaxLength(80).HasColumnType("varchar(60)");
            builder.Property(en => en.Numero).IsRequired().HasMaxLength(5).HasColumnType("int(5)");
            builder.Property(en => en.Complemento).HasMaxLength(5).HasColumnType("int(5)");
            builder.Property(en => en.Cidade).IsRequired().HasMaxLength(80).HasColumnType("varchar(80)");
            builder.Property(en => en.Estado).IsRequired().HasMaxLength(80).HasColumnType("varchar(60)");
        }
    }
}