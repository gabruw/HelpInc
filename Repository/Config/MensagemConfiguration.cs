using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class MensagemConfiguration : IEntityTypeConfiguration<Mensagem>
    {
        public void Configure(EntityTypeBuilder<Mensagem> builder)
        {
            builder.HasKey(pre => pre.Id);
            builder.HasOne(pre => pre.MensagemDestinatario).WithMany().HasForeignKey(pre => pre.IdDestinatario);
            builder.HasOne(pre => pre.MensagemRemetente).WithMany().HasForeignKey(pre => pre.IdRemetente);

            builder.Property(pre => pre.CaminhoTxt).IsRequired().HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(pre => pre.Data).HasMaxLength(8).HasColumnType("Date");

        } 
    }
}