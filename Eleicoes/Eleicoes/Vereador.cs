using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class Vereador : Candidato
    {
        public static ArrayList aVereador = new ArrayList();

        public Vereador(string cod, string nome, string email, string dataNascimento, Partido partido):base(nome, email, dataNascimento, partido)
        {
            // TryParse do codigo do Vereador
            int aux;
            bool ver = int.TryParse(cod, out aux);
            if (ver)
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

        public override string ToString()
        {
            return "Vereador -- Código: " + codigo + base.ToString();
        }
    }
}
