using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Urna
    {
        public static ArrayList aUrnas = new ArrayList();
        private int zona;
        private int secao;
        private int votosNulos;
        private int votosBrancos;
        private Candidato[] cadidatos;

        public Urna(string zona, string secao)
        {
            // TryParse da zona de eleição
            int aux;
            bool ver = int.TryParse(zona, out aux);
            if (ver)
                this.zona = aux;
            else
                throw new InvalidDataException("Valor digitado para zona de votação da Urna é invalido !\n"+
                    "Por favor, digite um valor de números inteiros !");

            // TryParse da seção de eleição
            int aux1;
            ver = int.TryParse(secao, out aux1);
            if(ver)
                this.secao = aux1;
            else
                throw new InvalidDataException("Valor digitado para seção de votação da Urna é invalido !\n" +
                    "Por favor, digite um valor de números inteiros !");
        }
    }
}
