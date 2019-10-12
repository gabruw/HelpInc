﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DTO
{
    public class Prestador : Default
    {
        public Prestador()
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

        // Somente para o mapeamento do Grupo
        public virtual Grupo GrupoPrestador { get; set; }

        public virtual ICollection<Habilidade> HabilidadePrestador { get; set; }

        [MinLength(1)]
        [MaxLength(255)]
        public string Nome { get; set; }

        [MaxLength(255)]
        public string Sobrenome { get; set; }

        [MinLength(10)]
        [MaxLength(10)]
        public int Telefone { get; set; }

        [MinLength(11)]
        [MaxLength(11)]
        public long? Celular { get; set; }

        [MinLength(11)]
        [MaxLength(11)]
        public long Cpf { get; set; }

        [MinLength(9)]
        [MaxLength(9)]
        public int Rg { get; set; }

        [MaxLength(1000)]
        public string Imagem { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (Nome.Length < 1)
            {
                AddError("O campo Nome do Prestador não foi informado.");
            }

            if (Celular.ToString().Length < 1)
            {
                AddError("O campo Celular do Prestador não foi informado.");
            }

            if (Celular.ToString().Length > 0 && Celular.ToString().Length < 11)
            {
                AddError("O campo Celular do Prestador não possuí o número de caracteres esperados.");
            }

            if (Telefone.ToString().Length < 1)
            {
                AddError("O campo Telefone do Prestador não foi informado.");
            }

            if (Telefone.ToString().Length > 0 && Telefone.ToString().Length < 10)
            {
                AddError("O campo Telefone do Prestador não possuí o número de caracteres esperados.");
            }

            if (Cpf.ToString().Length < 1)
            {
                AddError("O campo CPF do Prestador não foi informado.");
            }

            if (Cpf.ToString().Length > 0 && Cpf.ToString().Length < 11)
            {
                AddError("O campo CPF do Prestador não possuí o número de caracteres esperados.");
            }

            if (Rg.ToString().Length < 1)
            {
                AddError("O campo RG do Prestador não foi informado.");
            }

            if (Rg.ToString().Length > 0 && Rg.ToString().Length < 9)
            {
                AddError("O campo RG do Prestador não possuí o número de caracteres esperados.");
            }

            if (Imagem.Length > 1000)
            {
                AddError("O campo Imagem do Prestador possuí um caminho de acesso muito maior que o esperado.");
            }
        }
    }
}