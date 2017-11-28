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
        public static List<VicePrefeito> aVicePrefeito = new List<VicePrefeito>();
        public static List<Vereador> aVereador = new List<Vereador>();
        public static List<Prefeito> aPrefeitos = new List<Prefeito>();
        public static List<Partido> aPartidos = new List<Partido>();
        public static int totalVotos;
        private int zona;
        private int secao;
        private int votosNulosPref;
        private int votosBrancosPref;
        private int votosNulosVer;
        private int votosBrancosVer;

        public Urna(string zona, string secao)
        {
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

        public void SetVotos(int[,] votosPref, int[,] votosVer, int votosNulosPref, int votosBrancosPref, int votosNulosVer, int votosBrancosVer)
        {


            foreach (Vereador v in Urna.aVereador)
            {
                for (int c = 0; c < votosVer.GetLength(0); c++)
                {
                    if (v.GetCodigo() == votosVer[c, 0])
                    {
                        v.votos += votosVer[c, 1];
                    }
                }
            }



            foreach (Prefeito p in Urna.aPrefeitos)
            {
                for (int c = 0; c < votosPref.GetLength(0); c++)
                {
                    if (p.GetCodigo() == votosPref[c, 0])
                    {
                        p.votos += votosPref[c, 1];
                    }
                }
            }


            this.votosBrancosPref += votosBrancosPref;
            this.votosNulosPref += votosNulosPref;
            this.votosBrancosVer += votosBrancosVer;
            this.votosNulosVer += votosNulosVer;
            totalVotos++;
        }

        public static bool ExcluirUrna(int seca)
        {
            int cont = 0;
            foreach (Urna x in aUrnas)
            {
                if (x.secao == seca)
                {
                    Urna.aUrnas.Remove(aUrnas[cont]);
                    return true;
                }
                cont++;
            }
            return false;
        }
        public static void SalvarUrnas()
        {
            Stream salvar = File.Open("Urna.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(salvar);
            foreach (Urna U in aUrnas)
            {
                escritor.WriteLine(U.zona + ";" + U.secao);
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
