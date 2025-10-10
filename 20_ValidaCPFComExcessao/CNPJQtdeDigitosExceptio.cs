using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcessao
{
    public class CNPJQtdeDigitosException : Exception
    {
        public CNPJQtdeDigitosException() : base("O CNPJ deve ter 14 dígitos!") { }
    }
}
