using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _18_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu CPF:");
            string cpfDigitado = Console.ReadLine();

            IDocumento documento = new CPF(cpfDigitado);

            if (documento.Validar())
                Console.WriteLine("CPF válido!");
            else
                Console.WriteLine("CPF inválido!");
        }
    }
}