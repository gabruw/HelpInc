using System;
using System.Collections.Generic;
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

        public long IdDestinatario { get; set; }

        [ForeignKey("IdDestinatario")]
        public virtual Mensagem MensagemDestinatario { get; set; }

        public long IdRemetente { get; set; }

        [ForeignKey("IdRemetente")]
        public virtual Mensagem MensagemRemetente { get; set; }

        public virtual ICollection<Habilidade> HabilidadePrestador { get; set; }

        [MinLength(1)]
        [MaxLength(255)]
        public string CaminhoTxt { get; set; }


        //não sei se o tipo DATE é assim
        [Column(TypeName = "Date")]
        public DateTime Data { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (CaminhoTxt.Length < 1)
            {
                AddError("O campo Caminho da Mensagem não foi informado.");
            }



        }
    }
}