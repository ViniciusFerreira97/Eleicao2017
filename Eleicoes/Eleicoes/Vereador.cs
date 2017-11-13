using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Vereador : Candidato
    {
        public Vereador(int cod, string nome, string email, DateTime dataNascimento, Partido partido):base(nome, email, dataNascimento, partido)
        {
            this.codigo = cod;
        }

        public override string ToString()
        {
            return " Código: " + codigo + base.ToString();
        }
    }
}
