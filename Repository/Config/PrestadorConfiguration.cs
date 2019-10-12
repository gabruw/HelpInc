using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class PrestadorConfiguration : IEntityTypeConfiguration<Prestador>
    {
        public void Configure(EntityTypeBuilder<Prestador> builder)
        {
            builder.HasKey(pre => pre.Id);
            builder.HasOne(pre => pre.EmpresaLogin).WithMany().HasForeignKey(pre => pre.IdLogin);
            builder.HasOne(pre => pre.EmpresaEndereco).WithMany().HasForeignKey(pre => pre.IdEndereco);
            builder.HasOne(pre => pre.GrupoPrestador).WithMany(gru => gru.PrestadorGrupo).HasForeignKey(pre => pre.IdGrupo);
            builder.HasMany(pre => pre.HabilidadePrestador).WithOne(hab => hab.PrestadorHabilidade).HasForeignKey(hab => hab.Id);

            builder.Property(pre => pre.Nome).IsRequired(true).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(pre => pre.Sobrenome).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(pre => pre.Telefone).IsRequired(true).HasMaxLength(12).HasColumnType("bigint(12)");
            builder.Property(pre => pre.Celular).HasMaxLength(11).HasColumnType("bigint(11)");
            builder.HasIndex(pre => pre.Cpf).IsUnique(true);
            builder.HasIndex(pre => pre.Rg).IsUnique(true);
            builder.Property(pre => pre.Imagem).HasMaxLength(1000).HasColumnType("varchar(1000)");
        }
    }
}