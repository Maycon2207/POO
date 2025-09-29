using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            Console.WriteLine("digite o 1° nome ele deve conter no maximo 3 Caracteres");
            nomes.Add(Console.ReadLine());
            int limite = 3;
            if (nomes.Length <= limite)
            {
                nomes.Add(nomes);
                Console.WriteLine("Nome adicionado: " + nomes);
            }
            else
            {
                Console.WriteLine("O nome ultrapassa o limite de caracteres!");
            }

            Console.WriteLine("impressao de nomes ");
            foreach (string nome in nomes)
            {
                Console.WriteLine($"- {nome}");
            }
            Console.WriteLine("digite o 2º nome ele deve conter no maximo 3 Caracteres");
            nomes.Add(Console.ReadLine());
            Console.WriteLine("digite o 3° nome ele deve conter no maximo 3 Caracteres");
            nomes.Add(Console.ReadLine());
            Console.WriteLine("digite o 4° nome ele deve conter no maximo 3 Caracteres");
            nomes.Add(Console.ReadLine());
            Console.WriteLine("digite o 5° nome ele deve conter no maximo 3 Caracteres");
            nomes.Add(Console.ReadLine());
            int limite = 3;

            if (nomes.Length <= limite)
            {
                nomes.Add(nome);
                Console.WriteLine("Nome adicionado: " + nomes);
            }
            else
            {
                Console.WriteLine("O nome ultrapassa o limite de caracteres!");
            }

            Console.WriteLine("impressao de nomes ");
            foreach (string nome in nomes)
            {
                Console.WriteLine($"- {nome}");
            }





        }
    }
}
