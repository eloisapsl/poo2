using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15_05_24elo
{
    internal class Contato
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string telefone { get; set; }
        public TipoTelefone tipotelefone { get; set; }

        public Contato(int id, string nome, string sobrenome, string telefone, TipoTelefone tipotelefone)
        {
            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.telefone = telefone;
            this.tipotelefone = tipotelefone;
        }
    }
}
