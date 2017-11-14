using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Prefeito : Candidato
    {
        VicePrefeito vicePrefeito;
        public Prefeito(string cod, string nome, string email, DateTime dataNascimento, Partido partido, VicePrefeito vprefeito):base(nome, email, dataNascimento, partido)
        {
            this.vicePrefeito = vprefeito;

            // TryParse do codigo do Prefeito
            int aux;
            bool ver = int.TryParse(cod, out aux);
            if (ver)
                this.codigo = aux;
            else
                throw new InvalidDataException("Valor digitado para código do Prefeito é invalido !\n"+
                    "Por favor, digite um valor de 2 números !");
        }

        public override string ToString()
        {
            return "Prefeito -- Código: " + codigo + base.ToString();
        }
    }
}
