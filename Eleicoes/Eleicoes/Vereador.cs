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
    class Vereador : Candidato
    {
        public static List<Vereador> aVereador = new List<Vereador>();

        public Vereador(string cod, string nome, string email, string dataNascimento, Partido partido):base(nome, email, dataNascimento, partido)
        {
            // TryParse do codigo do Vereador
            int aux;
            bool ver = int.TryParse(cod, out aux);
            if (ver && aux > 999 && aux < 10000)
            {
                if (VerificaExistencia(aux))
                    this.codigo = aux;
                else
                    throw new InvalidDataException("Valor digitado para código do Vereador é invalido !\n" +
                        "Pois já existe um Vereador com esse código !");
            }
            else
                throw new InvalidDataException("Valor digitado para código do Vereador é invalido !\n" +
                    "Por favor, digite um valor de 4 números !");
        }

        protected override bool VerificaExistencia(int cod)
        {
            foreach (Vereador v in aVereador)
            {
                if (cod == v.codigo)
                {
                    return false;
                }
            }
            return true;
        }

        public static int VerificaPosicao(int x)
        {
            int cont = 0;
            foreach (Vereador v in aVereador)
            {
                if (x == v.codigo)
                    return cont;
                cont++;
            }
            return cont;
        }

        public static void ExcluirCandidato(int a)
        {
            aVereador[a].partido.contCandidatos -= 1;
            Vereador.aVereador.Remove(aVereador[a]);
        }

        public static void SalvarVereador()
        {
            Stream salvar = File.Open("Vereador.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(salvar);
            foreach (Vereador p in aVereador)
            {
                escritor.WriteLine(p.codigo + ";" + p.nome + ";" + p.email + ";" + p.dataNascimento + ";" + Partido.verificaPosicao(p.partido.getNome())+";"+p.votos);
            }
            escritor.Close();
            salvar.Close();
        }

        public static void InicializarVereador(string caminho)
        {
            aVereador.Clear();
            if (File.Exists("Vereador.txt"))
            {
                int cont = 0;
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    string[] campos = linha.Split(';');
                    aVereador.Add(new Vereador(campos[0], campos[1], campos[2], campos[3], (Partido)Partido.aPartidos[int.Parse(campos[4])]));
                    aVereador[cont].votos = int.Parse(campos[5]);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }
    }
}
