using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DTO
{
    public class Grupo : Default
    {
        public Grupo()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long IdPrestador { get; set; }

        [ForeignKey("IdPrestador")]
        public virtual Prestador GrupoPrestador { get; set; }

        public long IdPrestadorLider { get; set; }

        [ForeignKey("IdPrestadorLider")]
        public virtual Prestador GrupoPrestadorLider { get; set; }

        [MinLength(7)]
        [MaxLength(60)]
        public string Nome { get; set; }

        [MinLength(6)]
        [MaxLength(40)]
        public string Descricao { get; set; }

        [MinLength(6)]
        [MaxLength(40)]
        public string Imagem { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (Nome.Length < 1)
            {
                AddError("O campo Nome do Grupo não foi informado.");
            }

            if (Descricao.Length < 1)
            {
                AddError("O campo Descricao do Grupo não foi informado.");
            }

            if (Imagem.ToString().Length != 1)
            {
                AddError("O campo Imagem do Grupo não foi informado.");
            }
        }
    }
}
