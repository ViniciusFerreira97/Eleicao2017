using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Eleicoes
{
    class Urna
    {
        public static List<Urna> aUrnas = new List<Urna>();
        private int zona;
        private int secao;
        private int votosNulos;
        private int votosBrancos;
        private Candidato[] cadidatos;
        
        private int[,] votosPrefeitos = new int[Prefeito.aPrefeitos.Count, 2];
        private int[,] votosVereadores = new int[Vereador.aVereador.Count, 2];

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
        public override string ToString()
        {
            return "---Urna---  Zona: " + this.zona + "  Seção: " + this.secao;
        }
        public static int GetUrna(int zona, int secao)
        {
                int aux = 0;
                for (int c = 0; c < aUrnas.Count; c++)
                {
                    if (zona == aUrnas[c].zona && secao == aUrnas[c].secao)
                    {
                        aux = c;
                    }
                }
            return aux;
        }

        public void SetVotos(int[,] votosPref, int[,] votosVer, int votosNulo, int votosBrancos)
        {
            for(int c = 0; c < votosPrefeitos.GetLength(0); c++)
            {
                votosPrefeitos[c, 0] = votosPref[c, 0];
                votosPrefeitos[c, 1] = votosPref[c, 1];
            }

            for (int c = 0; c < votosVereadores.GetLength(0); c++)
            {
                votosVereadores[c, 0] = votosVer[c, 0];
                votosVereadores[c, 1] = votosVer[c, 1];
            }
        }
        public static void SalvarUrnas()
        {
            Stream salvar = File.Open(@"C:\Users\OTIMIZAÇÃO\Documents\Vinicius Git\Eleicao2017\Eleicoes\Eleicoes\bin\Debug\Urna.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(salvar);
            foreach (Urna U in aUrnas)
            {
                escritor.WriteLine(U.zona+";"+U.secao);
            }
            escritor.Close();
            salvar.Close();
        }
        public static void InicializarUrnas(string caminho)
        {
            if (File.Exists("Urna.txt"))
            {
                aUrnas.Clear();
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    string[] campos = linha.Split(';');
                    aUrnas.Add(new Urna(campos[0], campos[1]));
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }
    }
}
