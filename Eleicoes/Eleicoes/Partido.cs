using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Partido
    {
        public string nome;
        public static ArrayList aPartidos = new ArrayList();

        public Partido(string nome)
        {
            if (nome != "")
            {
                if (VerificaExistencia(nome))
                {
                    this.nome = nome;
                }
                else
                    throw new InvalidDataException("Nome de Partido já existente! \nPor favor insira um Partido com nome diferente dos já cadastrados !");
            }
            else
            {
                throw new InvalidDataException("Nome de Partido não pode ser vazio!");
            }
        }

        protected bool VerificaExistencia(string nome)
        {
            foreach (Partido p in aPartidos)
            {
                if (nome == p.nome)
                {
                    return false;
                }
            }
            return true;
        }

        public string getNome() { return this.nome; }

        public override string ToString()
        {
            return "Partido: " + nome;
        }

        //Clonar posição do array em que está o texto selecionado
        public static int verificaPosicao(string texto)
        {
            int aux = 0;
            foreach (Partido p in aPartidos)
            {
                if (texto.Equals(p.nome))
                {
                    return aux;
                }
                aux++;
            }
            return aux;
        }
    }
}
