using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAmigo.Domain
{
    public class Amigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Foto { get; set; }
        public string Telefone { get; set; }
        public string PaisOrigem { get; set; }
        public string EstadoOrigem { get; set; }
    }
}
