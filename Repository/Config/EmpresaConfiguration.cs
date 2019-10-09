using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasKey(emp => emp.Id);
            builder.HasOne(emp => emp.EmpresaLogin).WithMany().HasForeignKey(emp => emp.IdLogin);
            builder.HasOne(emp => emp.EmpresaEndereco).WithMany().HasForeignKey(emp => emp.IdEndereco);

            builder.Property(emp => emp.NomeFantasia).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.HasIndex(emp => emp.RazaoSocial).IsUnique();
            builder.Property(emp => emp.Telefone).IsRequired().HasMaxLength(10).HasColumnType("int(10)");
            builder.HasIndex(emp => emp.Cnpj).IsUnique();
            builder.Property(emp => emp.Imagem).HasMaxLength(1000).HasColumnType("varchar(1000)");
        }
    }
}