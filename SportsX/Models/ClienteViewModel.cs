﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsX.Models
{
    public class ClienteViewModel
    {
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "O CPF/CNPJ é obrigatório", AllowEmptyStrings = false)]
        [CustomValidationCPFCNPJ(ErrorMessage = "CPF ou CNPJ inválido")]
        [Display(Name = "CPF")]
        public string Identificador { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O CEP é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "O email é obrigatório", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "Por favor digite um email válido")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A classificação é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Classificação")]
        public byte Classificacao { get; set; }
        [Required(ErrorMessage = "O tipo é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Tipo")]
        public byte tipo { get; set; }
        [Required(ErrorMessage = "O Telefone é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        //public List<Telefone> Telefones { get; set; }
    }
}
