using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Eleicoes
{
    class Eleitor
    {
        public static List<Eleitor> aEleitores = new List<Eleitor>();
        private string nome;
        private DateTime dataNascimento;
        private string tituloEleitor;
        private int zona;
        private int secao;
        private bool jaVotou;

        public Eleitor(string nome, string dataNascimento, string tituloEleitor, string zona, string secao)
        {
            if (nome != "")
                this.nome = nome;
            else
                throw new InvalidDataException("NOME não pode ser vazio, preencha-o !");

            this.dataNascimento = DateTime.Parse(dataNascimento);

            if (tituloEleitor != "")
                this.tituloEleitor = tituloEleitor;
            else
                throw new InvalidDataException("TITULO DE ELEITOR não pode ser vazio, preencha-o !");

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
            this.jaVotou = false;
        }
        public static bool ExcluirEleitor(string titulo)
        {
            int cont = 0;
            foreach(Eleitor x in aEleitores)
            {
                if (x.tituloEleitor == titulo)
                {
                    Eleitor.aEleitores.Remove(aEleitores[cont]);
                    return true;
                }
                cont++;
            }
            return false;
        }
        public static bool VerificaExistencia(string titulo)
        {
            foreach (Eleitor e in aEleitores)
            {
                if (titulo == e.tituloEleitor)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool GetJaVotou (string titulo)
        {
            int aux = 0;
            for (int c = 0; c < aEleitores.Count; c++)
            {
                if (titulo == aEleitores[c].tituloEleitor)
                {
                    aux = c;
                }
            }
            return aEleitores[aux].jaVotou;
        }

        public static void ConfirmaVoto(string titulo)
        {

            int aux = 0;
            for (int c = 0; c < aEleitores.Count; c++)
            {
                if (titulo == aEleitores[c].tituloEleitor)
                {
                    aux = c;
                }
            }
            aEleitores[aux].jaVotou = true;
        }

        public static void GetZonaESecao(string titulo,out int zonaE,out int secaoE)
        {
            int aux = 0;
            for(int c = 0; c < aEleitores.Count; c++)
            {
                if(titulo == aEleitores[c].tituloEleitor)
                {
                    aux = c;
                }
            }
            zonaE = aEleitores[aux].zona;

            secaoE = aEleitores[aux].secao;
        }

        public override string ToString()
        {
            return "Eleitor -- Nome: " + nome + "Data de nascimento: " + dataNascimento +
                " Titulo de eleitor: " + tituloEleitor + " Zona: " + zona + " Seção: " + secao;
        }
        public static void SalvarEleitores()
        {
            Stream salvar = File.Open("Eleitor.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(salvar);
            foreach (Eleitor p in aEleitores)
            {
                escritor.WriteLine(p.nome + ";" + p.dataNascimento + ";" + p.tituloEleitor + ";" + p.zona + ";" + p.secao);
            }
            escritor.Close();
            salvar.Close();
        }
        public static void InicializarEleitores(string caminho)
        {
            if (File.Exists("Eleitor.txt"))
            {
                aEleitores.Clear();
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    string[] campos = linha.Split(';');
                    aEleitores.Add(new Eleitor(campos[0], campos[1], campos[2], campos[3], campos[4]));
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }
    }
}
