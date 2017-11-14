using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class VicePrefeito : Candidato
    {
        public VicePrefeito(string cod, string nome, string email, DateTime dataNascimento, Partido partido) :base(nome, email, dataNascimento, partido)
        {
            // TryParse do codigo do VicePrefeito
            int aux;
            bool ver = int.TryParse(cod, out aux);
            if (ver)
                this.codigo = aux;
            else
                throw new InvalidDataException("Valor digitado para código do Vice-Prefeito é invalido !\n" +
                    "Por favor, digite um valor de 2 números !");

        }

        public override string ToString()
        {
            return "Vice-Prefeito -- Código: " + codigo + base.ToString();
        }
    }
}
