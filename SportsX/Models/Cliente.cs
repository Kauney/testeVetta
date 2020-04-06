using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsX.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "O CPF/CNPJ é obrigatório", AllowEmptyStrings = false)]
        public string Identificador { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O CEP é obrigatório", AllowEmptyStrings = false)]
        public string CEP { get; set; }
        [Required(ErrorMessage = "O email é obrigatório", AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(ErrorMessage = "A classificação é obrigatória", AllowEmptyStrings = false)]
        //Refere ao classificação do cliente 0=Ativo, 1=Inativo, 2=Preferencial
        public int Classificacao { get; set; }
        [Required(ErrorMessage = "O tipo é obrigatório", AllowEmptyStrings = false)]
        //Refere ao tipo do cliente 0=Pessoa Física, 1=PessoaJurídica
        public int tipo { get; set; }
        [Required(ErrorMessage = "O Telefone é obrigatório", AllowEmptyStrings = false)]
        public string Telefone { get; set; }

        //public List<Telefone> Telefones { get; set; }
    }
}