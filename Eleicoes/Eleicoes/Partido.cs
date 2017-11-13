using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Partido
    {
        protected string nome;

        public Partido(string nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return " Partido: " + nome;
        }
    }
}
