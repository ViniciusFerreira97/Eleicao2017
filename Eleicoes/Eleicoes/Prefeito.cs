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
    class Prefeito : Candidato
    {
        VicePrefeito vicePrefeito;
        public static List<Prefeito> aPrefeitos = new List<Prefeito>();

        public Prefeito(string cod, string nome, string email, string dataNascimento, Partido partido, VicePrefeito vprefeito) : base(nome, email, dataNascimento, partido)
        {
            this.vicePrefeito = vprefeito;

            // TryParse do codigo do Prefeito
            int aux;
            bool ver = int.TryParse(cod, out aux);
            if (ver)
            {
                if(VerificaExistencia(aux))
                    this.codigo = aux;
                else
                    throw new InvalidDataException("Valor digitado para código do Prefeito é invalido !\n" +
                        "Pois já existe um Prefeito com esse código !");
            }
            else
                throw new InvalidDataException("Valor digitado para código do Prefeito é invalido !\n" +
                    "Por favor, digite um valor de 2 números !");
        }

        protected override bool VerificaExistencia(int cod)
        {
            foreach (Prefeito p in aPrefeitos)
            {
                if (cod == p.codigo)
                {
                    return false;
                }
            }
            return true;
        }
        public string GetNomeVice() { return vicePrefeito.GetNome(); }
        public override string ToString()
        {
            return "Prefeito -- Código: " + codigo + base.ToString();
        }
        public static void SalvarPrefeitos()
        {
            Stream salvar = File.Open(@"C:\Users\OTIMIZAÇÃO\Documents\Vinicius Git\Eleicao2017\Eleicoes\Eleicoes\bin\Debug\Prefeito.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(salvar);
            foreach (Prefeito p in aPrefeitos)
            {
                escritor.WriteLine(p.codigo+";"+p.nome+";"+p.email+";"+p.dataNascimento+";"+Partido.verificaPosicao(p.partido.getNome())+";"+VicePrefeito.VerificaPosicao(p.vicePrefeito.GetCodigo()));
            }
            escritor.Close();
            salvar.Close();
        }
        public static void InicializarPrefeitos(string caminho)
        {
            if (File.Exists("Prefeito.txt"))
            {
                aPrefeitos.Clear();
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    string[] campos = linha.Split(';');
                    aPrefeitos.Add(new Prefeito(campos[0], campos[1], campos[2], campos[3], (Partido)Partido.aPartidos[int.Parse(campos[4])], (VicePrefeito)VicePrefeito.aVicePrefeito[int.Parse(campos[5])]));
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }

    }
}
