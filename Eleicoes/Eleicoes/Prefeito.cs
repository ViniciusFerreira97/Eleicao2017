using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Prefeito : Candidato
    {
        public Prefeito(int cod, string nome, string email, DateTime aniversario, Partido partido):base(nome, email, aniversario, partido)
        {
            this.codigo = cod;
        }

        public override string ToString()
        {
            return " Código: " + codigo + base.ToString();
        }
    }
}
