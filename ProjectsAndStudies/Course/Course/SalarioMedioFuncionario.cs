using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    public class Funcionario2
    {
        public string Nome;
        public double Salario;

    }
    class SalarioMedioFuncionario
    {
        static void Main_(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("****Teste*****");
            Funcionario2 funcionario1 = new Funcionario2();
            Funcionario2 funcionario2 = new Funcionario2();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine($"Salário medio {media.ToString("f2", CultureInfo.InvariantCulture)}");

        }
    }
}
