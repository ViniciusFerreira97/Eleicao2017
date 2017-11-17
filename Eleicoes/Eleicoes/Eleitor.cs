using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Eleitor
    {
        public static ArrayList aEleitores = new ArrayList();
        private string nome;
        private DateTime dataNascimento;
        private string tituloEleitor;
        private int zona;
        private int secao;

        public Eleitor(string nome, string dataNascimento, string tituloEleitor, string zona, string secao)
        {
            this.nome = nome;
            this.dataNascimento = DateTime.Parse(dataNascimento);
            this.tituloEleitor = tituloEleitor;

            // TryParse da zona de eleição
            int aux;
            bool ver = int.TryParse(zona, out aux);
            if (ver)
                this.zona = aux;
            else
                throw new InvalidDataException("Valor digitado para zona de votação da Urna é invalido !\n" +
                    "Por favor, digite um valor de números inteiros !");

            // TryParse da seção de eleição
            int aux1;
            ver = int.TryParse(secao, out aux1);
            if (ver)
                this.secao = aux1;
            else
                throw new InvalidDataException("Valor digitado para seção de votação da Urna é invalido !\n" +
                    "Por favor, digite um valor de números inteiros !");
        }

        public override string ToString()
        {
            return "Eleitor -- Nome: " + nome + "Data de nascimento: " + dataNascimento +
                " Titulo de eleitor: " + tituloEleitor + " Zona: " + zona + " Seção: " + secao;
        }
    }
}
