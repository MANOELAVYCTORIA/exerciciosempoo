using System;
using System.Globalization;
namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            Console.Write("NOME: ");
            fun.Nome = Console.ReadLine();
            Console.Write("SALÁRIO BRUTO: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("IMPOSTO: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: "+fun);
            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            fun.AumentarSalario(porcentagem);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: "+fun);
        }
    }
}
