using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _21_ConversaoNumeroComExecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                int dobro = numero * 2;
                Console.WriteLine($"O dobro de {numero} é {dobro}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
            }

            Console.WriteLine("Programa finalizado!");
        }
    }
}
