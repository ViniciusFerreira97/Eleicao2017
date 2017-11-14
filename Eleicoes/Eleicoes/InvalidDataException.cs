using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicoes
{
    class InvalidDataException : FormatException
    {
        public InvalidDataException(string message):base(message)
        {

        }
    }
}
