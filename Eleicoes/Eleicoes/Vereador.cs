using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Vereador : Candidato
    {
        public Vereador(string cod, string nome, string email, DateTime dataNascimento, Partido partido):base(nome, email, dataNascimento, partido)
        {
            // TryParse do codigo do Vereador
            int aux;
            bool ver = int.TryParse(cod, out aux);
            if (ver)
                this.codigo = aux;
            else
                throw new InvalidDataException("Valor digitado para código do Vereador é invalido !\n" +
                    "Por favor, digite um valor de 4 números !");
        }

        public override string ToString()
        {
            return "Vereador -- Código: " + codigo + base.ToString();
        }
    }
}
