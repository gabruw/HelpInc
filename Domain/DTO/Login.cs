using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DTO
{
    public class Login : Default
    {
        public Login()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [MinLength(7)]
        [MaxLength(60)]
        public string Email { get; set; }

        [MinLength(6)]
        [MaxLength(40)]
        public string Senha { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public string Tipo { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (Email.Length < 1)
            {
                AddError("O campo Email do Login não foi informado.");
            }

            if (Senha.Length < 1)
            {
                AddError("O campo Senha do Login não foi informado.");
            }

            if (Senha.Length > 1 && Senha.Length < 6)
            {
                AddError("O campo Senha do Login não possuí o número de caracteres esperados.");
            }

            if (Tipo.Length != 1)
            {
                AddError("O campo Tipo do Login não foi informado.");
            }
        }
    }
}
