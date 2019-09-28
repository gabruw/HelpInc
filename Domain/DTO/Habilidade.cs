using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

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

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
