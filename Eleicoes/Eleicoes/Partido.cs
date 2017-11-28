using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eleicoes
{
    class Partido
    {
        public string nome;
        public string sigla;
        public int numero;
        public int contCandidatos = 0;

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
            foreach (Partido p in Urna.aPartidos)
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
            foreach (Partido p in Urna.aPartidos)
            {
                if (texto.Equals(p.nome))
                {
                    return aux;
                }
                aux++;
            }
            return aux;
        }
        public static void SalvarPartidos()
        {
            Stream salvar = File.Open("Partido.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(salvar);
            foreach (Partido p in Urna.aPartidos)
            {
                escritor.WriteLine(p.nome);
            }
            escritor.Close();
            salvar.Close();
        }
        public static void InicializarPartidos(string caminho)
        {
            Urna.aPartidos.Clear();
            if (File.Exists("Partido.txt"))
            {
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    Urna.aPartidos.Add(new Partido(linha));
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }

    }
}
