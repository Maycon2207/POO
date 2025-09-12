using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03_Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conta conta = new Conta();
            Conta conta = new Conta("12345-X");
            conta.setNome("Celso Serrano Araujo");
            // conta.Numero = "12345-X";
            //conta.saldo = -1000
            conta.Depositar(-1000.00m);

            //utilizando metodo acessador
            conta.setSaldo(1000.00m);
            //Console.WriteLine($"Saldo atual. {conta.getSaldo():c2}");
            conta.imprimirSaldo();
            while (true)

            {
                
                Console.WriteLine("informe a Operação: [D]-depositar, [S]-sacar ou [E]-sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("informe o valor do deposito:");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.imprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("informe o valor para saque:");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.imprimirSaldo();

                }
                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"conta: {conta.Nome} - {conta.getSaldo():c2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe Apenas as LEtras [D] para depositar, [S] para sacar ou [E] para sair");
                }


            }    
        }

    }
    public class Conta
    {
        private string numero;
        private string nome;


        //tranformar a conta saldo com acesso privado
        // public decimal saldo;
        private decimal saldo;
        public Conta(string numero)
        {
            this.numero = numero;
        }
        private string setnome;

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }


        public decimal getSaldo()
        {
            return saldo;
        }

        public void setSaldo(decimal saldo)
        {
            this.Depositar(saldo);
        }

        public string getNumero()
        {
            return numero;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;

            else
                Console.WriteLine("Valor invalido para deposito o valor deve ser maior que Zero");


        }
        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= saldo)
                saldo -= valor;
            else
                Console.WriteLine("Valor invalido para saque o valor deve ser maior que Zero e menor que o saldo atual");
            
        }

        public void imprimirSaldo()
        {
            Console.WriteLine($"Saldo atual. {getSaldo():c2}");
        }
    }
}
