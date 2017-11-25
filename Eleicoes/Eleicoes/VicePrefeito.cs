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
    class VicePrefeito : Candidato
    {
        public static ArrayList aVicePrefeito = new ArrayList();

        public VicePrefeito(string cod, string nome, string email, string dataNascimento, Partido partido) :base(nome, email, dataNascimento, partido)
        {
            // TryParse do codigo do VicePrefeito
            int aux;
            bool ver = int.TryParse(cod, out aux);
            if (ver)
            {
                if (VerificaExistencia(aux))
                    this.codigo = aux;
                else
                    throw new InvalidDataException("Valor digitado para código do Vice-Prefeito é invalido !\n" +
                        "Pois já existe um Vice-Prefeito com esse código !");
            }
            else
                throw new InvalidDataException("Valor digitado para código do Vice-Prefeito é invalido !\n" +
                    "Por favor, digite um valor de 2 números !");

        }

        protected override bool VerificaExistencia(int cod)
        {
            foreach (VicePrefeito v in aVicePrefeito)
            {
                if (cod == v.codigo)
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return "Vice-Prefeito -- Código: " + codigo + base.ToString();
        }
        public static int VerificaPosicao(int x)
        {
            int cont = 0;
            foreach (VicePrefeito v in aVicePrefeito)
            {
                if (x == v.codigo)
                    return cont;
                cont++; 
            }
            return cont;
        }
        public static void SalvarVice()
        {
            Stream salvar = File.Open("VicePrefeito.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(salvar);
            foreach (VicePrefeito p in aVicePrefeito)
            {
                escritor.WriteLine(p.codigo + ";" + p.nome + ";" + p.email + ";" + p.dataNascimento + ";" + Partido.verificaPosicao(p.partido.getNome()));
            }
            escritor.Close();
            salvar.Close();
        }
        public static void InicializarVice(string caminho)
        {
            aVicePrefeito.Clear();
            if (File.Exists("VicePrefeito.txt"))
            {
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    string[] campos = linha.Split(';');
                    aVicePrefeito.Add(new VicePrefeito(campos[0], campos[1], campos[2], campos[3], (Partido)Partido.aPartidos[int.Parse(campos[4])]));
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }
    }
}
