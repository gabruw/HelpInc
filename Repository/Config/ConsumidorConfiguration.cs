using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class ConsumidorConfiguration : IEntityTypeConfiguration<Consumidor>
    {
        public void Configure(EntityTypeBuilder<Consumidor> builder)
        {
            builder.HasKey(con => con.Id);
            builder.HasOne(con => con.EmpresaLogin).WithMany().HasForeignKey(con => con.IdLogin);
            builder.HasOne(con => con.EmpresaEndereco).WithMany().HasForeignKey(con => con.IdEndereco);

            builder.Property(con => con.Nome).IsRequired().HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(con => con.Telefone).IsRequired().HasMaxLength(10).HasColumnType("int(10)");
            builder.Property(con => con.Celular).HasMaxLength(11).HasColumnType("bigint(11)");
            builder.HasIndex(con => con.Cpf).IsUnique();
            builder.HasIndex(con => con.Rg).IsUnique();
            builder.Property(con => con.Imagem).HasMaxLength(1000).HasColumnType("varchar(1000)");
        }
    }
}