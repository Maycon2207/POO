using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcessao
{
    public class CNPJMesmoNumeroException : Exception
    {
        public CNPJMesmoNumeroException() : base("Todos os números do CNPJ não podem ser iguais!") { }
    }
    
    
}
