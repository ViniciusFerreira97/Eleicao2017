﻿using System;
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
        public Vereador(string cod, string nome, string email, string dataNascimento, Partido partido):base(nome, email, dataNascimento, partido)
        {
            // TryParse do codigo do Vereador
            int aux;
            bool ver = int.TryParse(cod, out aux);
            if (ver && aux > 999 && aux < 10000)
            {
                if (VerificaExistencia(aux))
                {
                    partido.contCandidatos++;
                    this.codigo = aux;
                }
                else
                    throw new InvalidDataException("Valor digitado para código do Vereador é invalido !\n" +
                        "Pois já existe um Vereador com esse código !");
            }
            else
                throw new InvalidDataException("Valor digitado para código do Vereador é invalido !\n" +
                    "Por favor, digite um valor de 2 números, já que os 2 primeiros números advém do Partido !");
        }


        public string GetPartidoSigla() { return partido.sigla; }

        protected override bool VerificaExistencia(int cod)
        {
            foreach (Vereador v in Urna.aVereador)
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
            foreach (Vereador v in Urna.aVereador)
            {
                if (x == v.codigo)
                    return cont;
                cont++;
            }
            return cont;
        }

        public static void ExcluirCandidato(int a)
        {
            Urna.aVereador[a].partido.contCandidatos -= 1;
            Urna.aVereador.Remove(Urna.aVereador[a]);
        }

        public static void SalvarVereador()
        {
            Stream salvar = File.Open("Vereador.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(salvar);
            foreach (Vereador p in Urna.aVereador)
            {
                escritor.WriteLine(p.codigo + ";" + p.nome + ";" + p.email + ";" + p.dataNascimento + ";" + Partido.verificaPosicao(p.partido.getNome())+";"+p.votos);
            }
            escritor.Close();
            salvar.Close();
        }

        public static void InicializarVereador(string caminho)
        {
            Urna.aVereador.Clear();
            if (File.Exists("Vereador.txt"))
            {
                int cont = 0;
                Stream entrada = File.Open(caminho, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    string[] campos = linha.Split(';');
                    Urna.aVereador.Add(new Vereador(campos[0], campos[1], campos[2], campos[3], (Partido)Urna.aPartidos[int.Parse(campos[4])]));
                    Urna.aVereador[cont].votos = int.Parse(campos[5]);
                    cont++;
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }
    }
}
