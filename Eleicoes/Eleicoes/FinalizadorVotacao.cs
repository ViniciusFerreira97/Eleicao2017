using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class FinalizadorVotacao
    {
        public int[,] vVereadores = new int[Vereador.aVereador.Count, 2];
        Prefeito vencedor;
        Prefeito[] vSegundoTurno = new Prefeito[2];
        int totalVotosPrefeitos;

        public FinalizadorVotacao(List<Urna> lUrnas)
        {
            SomaVereadores(lUrnas);
            OrdenaMatriz(vVereadores);

           
        }

        private void SomaVereadores(List<Urna> lUrnas)
        {
            //Este foreach preenche toda a primeira coluna de vVereadores com o código dos vereadores existentes e a segunda coluna ele zera para realizar a soma
            int aux = 0;
            foreach (Vereador v in Vereador.aVereador)
            {
                vVereadores[aux, 0] = v.GetCodigo();
                vVereadores[aux, 1] = 0;
            }

            //Este foreach realiza a soma de todos os votos de vereadores
            // Para cada urna na lista de urnas
            foreach (Urna u in lUrnas)
            {
                for (int j = 0; j < vVereadores.GetLength(1); j++)
                {
                    for (int i = 0; i < u.votosVereadores.Length; i++)
                    {
                        //verifica se o código de cada vereador no vVereadores é igual ao código de cada vereador no votosVeradores da urna atual
                        if (vVereadores[j, 0] == u.votosVereadores[i, 0])
                        {
                            //caso seja igual soma-se os votos e então quebra o for, para somar o número de votos de outro candidato presente na urna
                            vVereadores[j, 1] += u.votosVereadores[i, 1];
                        }
                    }
                }
            }
        }

        public void OrdenaMatriz(int[,] matriz)
        {
            //Utilização do metodo Gnome Sort para organizar a matriz em ordem de quem tem menos votos
            int p = 0;
            int aux, aux2;
            while (p < (matriz.GetLength(1) - 1))
            {
                if (matriz[p, 1] > matriz[p + 1, 1])
                {
                    aux = matriz[p, 1];
                    aux2 = matriz[p, 0];
                    matriz[p, 1] = matriz[p + 1, 1];
                    matriz[p, 0] = matriz[p + 1, 0];
                    matriz[p + 1, 1] = aux;
                    matriz[p + 1, 0] = aux;
                    if (p > 0)
                    {
                        p -= 2;
                    }
                }
                p++;
            }
        }
    }
}
