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
            builder.HasMany(pre => pre.HabilidadePrestador).WithOne(hab => hab.PrestadorHabilidade).HasForeignKey(hab => hab.Id);

            builder.Property(pre => pre.Nome).IsRequired().HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(pre => pre.Sobrenome).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(pre => pre.Telefone).IsRequired().HasMaxLength(10).HasColumnType("int(10)");
            builder.Property(pre => pre.Celular).HasMaxLength(11).HasColumnType("bigint(11)");
            builder.HasIndex(pre => pre.Cpf).IsUnique();
            builder.HasIndex(pre => pre.Rg).IsUnique();
            builder.Property(pre => pre.Imagem).HasMaxLength(1000).HasColumnType("varchar(1000)");
        }
    }
}