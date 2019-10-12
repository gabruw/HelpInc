using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class MensagemConfiguration : IEntityTypeConfiguration<Mensagem>
    {
        public void Configure(EntityTypeBuilder<Mensagem> builder)
        {
            builder.HasKey(men => men.Id);
            builder.Property(men => men.IdDestinatario).IsRequired().HasMaxLength(1).HasColumnType("bigint(11)");
            builder.Property(men => men.IdRemetente).IsRequired().HasMaxLength(1).HasColumnType("bigint(11)");
            builder.Property(men => men.CaminhoTxt).IsRequired().HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(men => men.Data).IsRequired().HasMaxLength(8).HasColumnType("date");
        } 
    }
}