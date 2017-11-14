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
            if (Verifica(nome))
            {
                this.nome = nome;
            }
            else
                throw new InvalidDataException("Nome de Partido já existente");
        }
        private bool Verifica (string nome)
        {
            foreach (Partido p in Form2.aPartidos)
            {
                if(nome == p.nome)
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
