using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    abstract class Candidato
    {
        protected int codigo;
        protected string nome;
        protected string email;
        protected DateTime aniversario;
        protected Partido partido;

        public Candidato(string nome, string email, DateTime aniversario, Partido partido)
        {
            this.nome = nome;
            this.email = email;
            this.aniversario = aniversario;
            this.partido = partido;
        }

        public override string ToString()
        {
            return "Código: " + codigo + " Nome: " + nome + " Email: " + email + " Aniversario: " + aniversario + " Partido: " + Partido;
        }
    }
}
