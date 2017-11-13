using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Urna
    {
        private int zona;
        private int secao;
        private int votosNulos;
        private int votosBrancos;
        private Candidato[] cadidatos;

        public Urna(int zona, int secao)
        {
            this.zona = zona;
            this.secao = secao;
        }
    }
}
