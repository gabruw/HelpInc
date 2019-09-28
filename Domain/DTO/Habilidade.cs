using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DTO
{
    public class Habilidade : Default
    {
        public Habilidade()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        // Somente para o mapeamento do Prestador
        public virtual Prestador PrestadorHabilidade { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public char Nivel { get; set; }

        [MaxLength(300)]
        public string Descricao { get; set; }

        [MinLength(1)]
        [MaxLength(15)]
        public double ValorBase { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (Nivel.ToString().Length != 1)
            {
                AddError("O campo Nivel da Habilidade não foi informado.");
            }

            if (ValorBase.ToString().Length < 1)
            {
                AddError("O campo Valor Base da Habilidade não foi informado.");
            }
        }
    }
}
