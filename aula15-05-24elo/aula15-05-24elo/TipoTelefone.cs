using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15_05_24elo
{
    internal class TipoTelefone
    {
        public int id;
        public string nome;

        public TipoTelefone(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public override string ToString()
        {
            return nome.ToString();
        }
    }
}
