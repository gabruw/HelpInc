using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(log => log.Id);

            builder.HasIndex(log => log.Email).IsUnique();
            builder.Property(log => log.Senha).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(log => log.Tipo).IsRequired().HasMaxLength(1).HasColumnType("char(1)");
        }
    }
}