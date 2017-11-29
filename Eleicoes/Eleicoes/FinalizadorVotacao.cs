using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class FinalizadorVotacao
    {
        Prefeito vencedor;
        Prefeito[] vSegundoTurno = new Prefeito[2];
        int totalVotosPrefeitos;

        public FinalizadorVotacao(List<Vereador> aVereador)
        {
            VerificaGanhadorPrefeito();
            foreach(Prefeito p in Urna.aPrefeitos)
            {
                totalVotosPrefeitos += p.votos;
            }
        }

        public Prefeito getVencedor()
        {
            return this.vencedor;
        }

        public Prefeito[] getSegundoTurno()
        {
            return this.vSegundoTurno;
        }

        public void VerificaGanhadorPrefeito()
        {
            //Guarda o número de votos do cadidato com maior número
            int maisVotado = -1;
            //Guarda o número de votos do cadidato com segundo maior número
            int segundoVotado = -1;
            //Guarda a posição do prefeito com maior número de votos
            int aux = 0;
            //Guarda a posição do prefeito com com segundo maior número de votos
            int aux2 = 0;
            int cont = 0;

            foreach (Prefeito pre in Urna.aPrefeitos)
            {
                //Verefica se o voto atual do prefeito é maior que o voto já guardado, se for, o atual passa para segundo e o novo para primeiro
                if (pre.votos > maisVotado)
                {
                    maisVotado = pre.votos;
                    aux2 = aux;
                    aux = cont;
                } // Caso nao for, verifica se é maior que o segundo guardado
                else if (pre.votos > segundoVotado)
                {
                    segundoVotado = pre.votos;
                    aux2 = cont;
                }
                cont++;
            }
            //Verifica se o maior tem mais que 51% dos votos, caso tenha ele ganhou
            if (maisVotado >= totalVotosPrefeitos * 0.51)
                vencedor = Urna.aPrefeitos[aux];
            else// Caso não tenha mais que 51%, haverá segundo turno, caso haja voto
            {
                vSegundoTurno[0] = Urna.aPrefeitos[0];
                vSegundoTurno[1] = Urna.aPrefeitos[1];
            }
        }

    }
}
