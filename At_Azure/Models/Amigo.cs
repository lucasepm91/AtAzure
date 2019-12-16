using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace At_Azure.Models
{
    public class Amigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
        public string Foto { get; set; }
        public string Telefone { get; set; }

        [Display(Name = "País")]
        public string PaisOrigem { get; set; }

        [Display(Name = "Estado")]
        public string EstadoOrigem { get; set; }
    }
}
