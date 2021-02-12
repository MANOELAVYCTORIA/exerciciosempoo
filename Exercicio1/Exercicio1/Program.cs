using System;
using System.Globalization;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret  = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            ret.Altura = double.Parse(Console.ReadLine());
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA: "+ ret.Area());
            Console.WriteLine("PERIMETRO: "+ ret.Perimetro());
            Console.WriteLine("DIAGONAL: "+ ret.Diagonal());
        }
    }
}
