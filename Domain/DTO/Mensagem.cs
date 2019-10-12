using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DTO
{
    public class Mensagem : Default
    {
        public Mensagem()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [MinLength(1)]
        [MaxLength(11)]
        public long IdDestinatario { get; set; }

        [MinLength(1)]
        [MaxLength(11)]
        public long IdRemetente { get; set; }

        [MinLength(1)]
        [MaxLength(255)]
        public string CaminhoTxt { get; set; }

        public DateTime Data { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (CaminhoTxt.Length < 1)
            {
                AddError("O campo Caminho da Mensagem não foi informado.");
            }

            if (CaminhoTxt.Length < 1)
            {
                AddError("O campo Caminho da Mensagem não foi informado.");
            }
        }
    }
}