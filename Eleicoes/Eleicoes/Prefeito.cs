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

        public Prefeito(string cod, string nome, string email, string dataNascimento, Partido partido, VicePrefeito vprefeito) : base(nome, email, dataNascimento, partido)
        {
            this.vicePrefeito = vprefeito;

            // TryParse do codigo do Prefeito
            int aux;
            bool ver = int.TryParse(cod, out aux);
            if (ver)
            {
                if (VerificaExistencia(aux))
                {
                    partido.contCandidatos ++;
                    this.codigo = aux;
                }
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
            foreach (Prefeito p in Urna.aPrefeitos)
            {
                if (cod == p.codigo)
                {
                    return false;
                }
            }
            return true;
        }

        public static int VerificaPosicao(int x)
        {
            int cont = 0;
            foreach (Prefeito v in Urna.aPrefeitos)
            {
                if (x == v.codigo)
                    return cont;
                cont++;
            }
            return cont;
        }
        public int GetCodVice() { return vicePrefeito.GetCodigo(); }
        public string GetPartido() { return partido.nome; }
        public string GetNomeVice() { return vicePrefeito.GetNome(); }

        public override string ToString()
        {
            return "Prefeito -- Código: " + codigo + base.ToString();
        }
        public static void ExcluirCandidato(int a, int b, int c)
        {
            Urna.aPrefeitos[a].partido.contCandidatos -= 1;
            Urna.aPrefeitos.Remove(Urna.aPrefeitos[a]);
            Urna.aVicePrefeito.Remove(Urna.aVicePrefeito[b]);
        }
        public static void SalvarPrefeitos()
        {
            Stream salvar = File.Open("Prefeito.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(salvar);
            foreach (Prefeito p in Urna.aPrefeitos)
            {
                escritor.WriteLine(p.codigo+";"+p.nome+";"+p.email+";"+p.dataNascimento+";"+Partido.verificaPosicao(p.partido.getNome())+";"+VicePrefeito.VerificaPosicao(p.vicePrefeito.GetCodigo())+";" + p.votos);
            }
            escritor.Close();
            salvar.Close();
        }
        public static void InicializarPrefeitos(string caminho)
        {
            if (File.Exists("Prefeito.txt"))
            {
                int cont = 0;
                Urna.aPrefeitos.Clear();
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    string[] campos = linha.Split(';');
                    Urna.aPrefeitos.Add(new Prefeito(campos[0], campos[1], campos[2], campos[3], (Partido)Urna.aPartidos[int.Parse(campos[4])], (VicePrefeito)Urna.aVicePrefeito[int.Parse(campos[5])]));
                    Urna.aPrefeitos[cont].votos = int.Parse(campos[6]);
                    cont++;
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }

    }
}
