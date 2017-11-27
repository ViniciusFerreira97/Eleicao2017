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
        public int votos;

        public Candidato(string nome, string email, string dataNascimento, Partido partido)
        {
            if (nome != "")
                this.nome = nome;
            else
                throw new InvalidDataException("NOME não pode ser vazio, preencha-o !");

            if (email != "")
                this.email = email;
            else
                throw new InvalidDataException("EMAIL não pode er vazio, preencha-o");

            this.partido = partido;
            this.partido.contCandidatos++;

            //TryParse Data Nascimento
            DateTime aux;
            bool ver = DateTime.TryParse(dataNascimento, out aux);
            if (ver)
                this.dataNascimento = DateTime.Parse(dataNascimento);
            else
            {
                throw new InvalidDataException("Insira um valor de DATA que seja válido!");
            }
        }

        abstract protected bool VerificaExistencia(int cod);

        public string GetNome()
        {
            return this.nome;
        }
        public string GetNomePartido()
        {
            return partido.getNome();
        }
        public int GetCodigo()
        {
            return codigo;
        }
        public override string ToString()
        {
            return "Código: " + codigo + " Nome: " + nome + " Email: " + email +
                " Aniversario: " + dataNascimento + " Partido: " + partido;
        }
    }
}
