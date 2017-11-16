using System;
using System.Collections;
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
        protected DateTime dataNascimento;
        protected Partido partido;

        public Candidato(string nome, string email, string dataNascimento, Partido partido)
        {
            this.nome = nome;
            this.email = email;
            this.partido = partido;
            DateTime aux;
            bool ver = DateTime.TryParse(dataNascimento, out aux);
            if(ver)
            this.dataNascimento = DateTime.Parse(dataNascimento);
            else
            {
                throw new InvalidDataException("Insira um valor de data que seja válido!");
            }
        }

        abstract protected bool VerificaExistencia(int cod);

        public override string ToString()
        {
            return "Código: " + codigo + " Nome: " + nome + " Email: " + email +
                " Aniversario: " + dataNascimento + " Partido: " + partido;
        }
    }
}
