using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
