using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Funcionario3
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return $"{Nome}, $ " + SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture);
        }

        static void Main_()
        {
            Funcionario3 f = new Funcionario3();

            Console.WriteLine("Informe os dados do funcionário: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.AumentarSalario(imposto);

            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}
