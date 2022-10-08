using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Course
{
    
    class NotaAluno2
    {
        public class Aluno
        {
            public string Nome;
            public double Nota1;
            public double Nota2;
            public double Nota3;
        }

        static void Main()
        {
            Aluno aluno = new Aluno();
            
            Console.WriteLine("Exemplo 1");
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double count = (aluno.Nota1 + aluno.Nota2 + aluno.Nota3);

            double pontoMinimo = 60.00;

            Console.WriteLine("NOTA FINAL = " + count);

            if(count >= pontoMinimo)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }

    }
}
