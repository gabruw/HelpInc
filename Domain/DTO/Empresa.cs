using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DTO
{
    public class Empresa : Default
    {
        public Empresa()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long IdLogin { get; set; }

        [ForeignKey("IdLogin")]
        public virtual Login EmpresaLogin { get; set; }

        public long IdEndereco { get; set; }

        [ForeignKey("IdEndereco")]
        public virtual Endereco EmpresaEndereco { get; set; }

        [MinLength(1)]
        [MaxLength(60)]
        public string NomeFantasia { get; set; }

        [MinLength(1)]
        [MaxLength(60)]
        public string RazaoSocial { get; set; }

        [MinLength(10)]
        [MaxLength(12)]
        public long? Telefone { get; set; }

        [MinLength(14)]
        [MaxLength(14)]
        public long Cnpj { get; set; }

        [MaxLength(1000)]
        public string Imagem { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if(NomeFantasia.Length < 1)
            {
                AddError("O campo Nome Fantasia da Empresa não foi informado.");
            }

            if (RazaoSocial.Length < 1)
            {
                AddError("O campo Razão Social da Empresa não foi informado.");
            }

            if (Telefone.ToString().Length < 1)
            {
                AddError("O campo Telefone do Empresa não foi informado.");
            }

            if (Telefone.ToString().Length > 0 && Telefone.ToString().Length < 10)
            {
                AddError("O campo Telefone do Empresa não possuí o número de caracteres esperados.");
            }

            if (Cnpj.ToString().Length < 1)
            {
                AddError("O campo CNPJ da Empresa não foi informado.");
            }

            if (Cnpj.ToString().Length > 0 && Cnpj.ToString().Length < 14)
            {
                AddError("O campo CNPJ da Empresa não possuí o número de caracteres esperados.");
            }
        }
    }
}
