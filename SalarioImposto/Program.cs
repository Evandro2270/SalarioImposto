using SalarioImposto;
using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Funcionario fun = new Funcionario();

                Console.Write("Nome: ");
                fun.Nome = Console.ReadLine();
                Console.Write("Salario Bruto: ");
                fun.SalarioBruto = double.Parse(Console.ReadLine(), CI);    
                Console.Write("Imposto: ");
                fun.Imposto = double.Parse(Console.ReadLine(), CI);

                Console.WriteLine();
                Console.WriteLine("Funcionario: " + fun);

                Console.WriteLine();
                Console.WriteLine("Deseja aumentar o salario em qual porcentagem? ");
                double porcent = double.Parse(Console.ReadLine(), CI);
                fun.AumentarSalario(porcent);

                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + fun);
            }
        }
    }
}