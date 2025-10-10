using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet <int> setNumeros = new HashSet<int>();
            setNumeros.Add(10);
            setNumeros.Add(20);
            setNumeros.Add(30);
            setNumeros.Add(40);
            setNumeros.Add(50);
            setNumeros.Add(20);
            setNumeros.Add(30);
            setNumeros.Add(60);
            setNumeros.Add(70);
            setNumeros.Add(10);

            Console.WriteLine("Impressão dos setNumeros: ");
            foreach (int numero in setNumeros)
            {
                Console.WriteLine($" - {numero}");
            }



        }
    }
}
