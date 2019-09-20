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

        public string Email { get; set; }

        public string Senha { get; set; }

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

            if (Tipo.Length != 1)
            {
                AddError("O campo Tipo do Login não foi informado ou está preeenchido erroneamente.");
            }
        }
    }
}
