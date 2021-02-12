using System;
using System.Globalization;
namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alu = new Aluno();
            Console.WriteLine("Nome do aluno: ");
            alu.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            alu.Nota1 = double.Parse(Console.ReadLine());
            alu.Nota2 = double.Parse(Console.ReadLine());
            alu.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = "
                + alu.NotaFinal());
            
            if (alu.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "+alu.NotaRestante() + "PONTOS");
            }
        }
    }
}
