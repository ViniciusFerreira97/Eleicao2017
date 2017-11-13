using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class VicePrefeito : Candidato
    {
        private Prefeito prefeito;
        public VicePrefeito(int cod, string nome, string email, DateTime dataNascimento, Partido partido, Prefeito prefeito) :base(nome, email, dataNascimento, partido)
        {
            this.codigo = cod;
            this.prefeito = prefeito;
        }

        public override string ToString()
        {
            return " Código: " + codigo + base.ToString();
        }
    }
}
