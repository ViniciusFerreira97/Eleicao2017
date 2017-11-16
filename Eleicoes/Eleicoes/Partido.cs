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
        protected string nome;
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

        public override string ToString()
        {
            return " Partido: " + nome;
        }
    }
}
