using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DTO
{
    public class Endereco : Default
    {
        public Endereco()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [MinLength(8)]
        [MaxLength(8)]
        public int Cep { get; set; }

        [MinLength(1)]
        [MaxLength(80)]
        public string Rua { get; set; }

        [MinLength(1)]
        [MaxLength(60)]
        public string Bairro { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public int Numero { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public int? Complemento { get; set; }

        [MinLength(1)]
        [MaxLength(80)]
        public string Cidade { get; set; }

        [MinLength(1)]
        [MaxLength(80)]
        public string Estado { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        public string Referencia { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (Cep.ToString().Length < 8)
            {
                AddError("O campo CEP do Endereço não foi informado.");
            }

            if (Rua.Length < 1)
            {
                AddError("O campo Rua do Endereço não foi informado.");
            }

            if (Bairro.Length < 1)
            {
                AddError("O campo Bairro do Endereço não foi informado.");
            }

            if (Numero.ToString().Length < 1)
            {
                AddError("O campo Número do Endereço não foi informado.");
            }

            if (Cidade.Length < 1)
            {
                AddError("O campo Cidade do Endereço não foi informado.");
            }

            if (Estado.Length < 1)
            {
                AddError("O campo Estado do Endereço não foi informado.");
            }
        }
    }
}