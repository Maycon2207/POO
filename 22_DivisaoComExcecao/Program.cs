using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um numero inteiro: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Digite outro numero inteiro: ");
                int numero2 = int.Parse(Console.ReadLine());

                int resultado = numero / numero2;
                Console.WriteLine("O resultado da divisao e: " + resultado);

            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Nao e possivel dividir por zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas numero inteiros.");
            }
            
            finally
            {
                Console.WriteLine("Operação Finalizada. Obrigador por utilizar o programa.");
            }


        }
    }
}
