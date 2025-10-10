using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcessao
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //string cpf =  Console.ReadLine();
            //CPF objCPF = new CPF( cpf );
            IDocumento documento;
            while (true)
            {
                Console.Write("Digite o CPF: ");
                try
                {
                    documento = new CPF(Console.ReadLine());
                    break;
                }
                catch (CPFQtdeDigitosException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (CPFMesmoNumeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CPF inválido: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");
            while (true)
            { 
            Console.Write("Digite o CNPJ: ");
            try
            {
                documento = new CNPJ(Console.ReadLine());
                break;

            }
                catch (CNPJQtdeDigitosException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (CNPJMesmoNumeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CNPJ inválido: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }



            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");
        }
    }
}
