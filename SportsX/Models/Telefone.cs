
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsX.Models
{
    [Table("Telefone")]
    public class Telefone
    {
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "O telefone é obrigatório", AllowEmptyStrings = false)]
        public string Numero{ get; set; }
    }
}