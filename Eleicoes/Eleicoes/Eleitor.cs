using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Eleitor
    {
        private string nome;
        private DateTime dataNascimento;
        private string tituloEleitor;
        private int zona;
        private int secao;

        public Eleitor(string nome, DateTime dataNascimento, string tituloEleitor, int zona, int secao)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.tituloEleitor = tituloEleitor;
            this.zona = zona;
            this.secao = secao;
        }

        public override string ToString()
        {
            return "Nome: " + nome + "Data de nascimento: " + dataNascimento +
                " Titulo de eleitor: " + tituloEleitor + " Zona: " + zona + " Seção: " + secao;
        }
    }
}
