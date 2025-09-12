using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sem o filtro do construtor
            Quadrado quadrado = new Quadrado();
            quadrado.ImprimeArea();

            Quadrado quadrado2 = new Quadrado(10);
            quadrado2.ImprimeArea();

            Retangulo retangulo = new Retangulo(5, 6);
            retangulo.ImprimeArea();

            Circulo obj4 = new Circulo(4);
            obj4.ImprimeArea();

            Triangulo obj5 = new Triangulo(4, 5);
            obj5.ImprimeArea();


        }
        
       
    }
    public class Quadrado
    {
        //modificado de acesso private
        //pode ser acessado apenas dentro da classe
        private int lado;   // como estou usando private la em cima nao deixa puxar entao tenho que usar o construtor 

        public Quadrado(int Lado)
        {
            this.lado = Lado;
        }
        //overload ( sobrecarga ) outro modo de contrutor um recebe parametro outro nao
        //declarar mais de um contrutor com a lista de argumento diferentes
        //this(5) acima o contrutor que recebe um parametro.
        public Quadrado():this(5)
        {
           // this.lado = 5;
        }
        public int CalculaArea()

        {
            return lado * lado;
            //o contrutor serve para instanciar o obejto e inicializar os atributos
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {lado} possui uma area de {CalculaArea()}");

        }
        //this - referencia o objeto atual
    }
    public class Retangulo
    {
        private int largura;
        private int altura;

        public Retangulo(int Largura, int Altura)
        {
            this.largura = Largura;
            this.altura = Altura;
        }
        public int CalculaArea()
        {
            return largura * altura;

        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Retangulo com largura de {largura} e altura de {altura} possui uma area de {CalculaArea()}");
        }

    }
    public class Circulo
    {
        private double raio;
        private const double pi = 3.14;
        public Circulo(double Raio)
        {
            this.raio = Raio;
        }
        public double CalculaArea()
        {
            return pi * (raio * raio);
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Circulo com raio de {raio} possui uma area de {CalculaArea()}");
        }
    }
    public class Triangulo
    {
        private int base1;
        private int altura;
        public Triangulo(int Base, int Altura)
        {
            this.base1 = Base;
            this.altura = Altura;
        }
        public double CalculaArea()
        {
            return (base1 * altura) / 2.0;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Triangulo com base de {base1} e altura de {altura} possui uma area de {CalculaArea()}");
        }
    }
} 

//sempre que for private a inicial e minuscula 







