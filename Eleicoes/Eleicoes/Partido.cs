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
    class Partido
    {
        public string nome;
        public string sigla;
        public int numero;
        public int contCandidatos = 0;

        public Partido(string nome, string sigla, string numero)
        {
            if (numero != "")
            {
                if (VerificaExistencia(nome))
                {
                    this.sigla = sigla;
                    this.nome = nome;
                }
                else
                    throw new InvalidDataException("Nome de Partido já existente! \nPor favor insira um Partido com nome diferente dos já cadastrados !");

                int aux;
                bool ok = int.TryParse(numero, out aux);
                if (ok)
                {
                    if(VerificaCod(aux))
                        this.numero = aux;
                    else
                        throw new InvalidDataException("Número de Partido já existente! \nPor favor insira um Partido com número diferente dos já cadastrados");

                }
                else
                    throw new InvalidDataException("Número do Partido é inválido");
            }
            else
            {
                throw new InvalidDataException("Nenhum campo pode ser vazio!");
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
        protected bool VerificaCod(int x)
        {
            foreach (Partido p in Urna.aPartidos)
            {
                if (x == p.numero)
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
        //Função para excluir partido
        public static void ExcluirPartido(int numero)
        {
            int aux = -1;
            for (int i = 0; aux == -1; i++)
            {
                if (numero == Urna.aPartidos[i].numero) //Verificando qaul posição ele se encontra
                    aux = i;
            }
            Partido x = Urna.aPartidos[aux];
            if (x.contCandidatos == 0)
            {
                Urna.aPartidos.Remove(x);
                MessageBox.Show("Partido Excluido");
            }
            else
                MessageBox.Show("O partido não pode ser excluido de houver candidatos", "Erro Excluir Partido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void SalvarPartidos()
        {
            Stream salvar = File.Open("Partido.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(salvar);
            foreach (Partido p in Urna.aPartidos)
            {
                escritor.WriteLine(p.nome+";"+p.sigla+";"+ p.numero);
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
                    string[] campos = linha.Split(';');
                    Urna.aPartidos.Add(new Partido(campos[0], campos[1], campos[2]));
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }

    }
}
