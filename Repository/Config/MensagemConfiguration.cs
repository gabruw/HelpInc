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
            builder.HasOne(men => men.MensagemDestinatario).WithMany().HasForeignKey(men => men.IdDestinatario);
            builder.HasOne(men => men.MensagemRemetente).WithMany().HasForeignKey(men => men.IdRemetente);

            builder.Property(men => men.CaminhoTxt).IsRequired().HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(men => men.Data).HasMaxLength(8).HasColumnType("Date");

        } 
    }
}