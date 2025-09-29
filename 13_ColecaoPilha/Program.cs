using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            int numero;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($" Informe o {i}º Número: ");
                numero = int.Parse( Console.ReadLine() );   
                numeros.Push( numero );
            }
            Console.WriteLine( numeros.Pop() );
        }
    }
}
