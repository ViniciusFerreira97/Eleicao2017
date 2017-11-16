using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Prefeito : Candidato
    {
        VicePrefeito vicePrefeito;
        public static ArrayList aPrefeitos = new ArrayList();

        public Prefeito(string cod, string nome, string email, DateTime dataNascimento, Partido partido, VicePrefeito vprefeito) : base(nome, email, dataNascimento, partido)
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

        public override string ToString()
        {
            return "Prefeito -- Código: " + codigo + base.ToString();
        }
    }
}
