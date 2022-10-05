using System;
using System.Globalization;

namespace Course
{
    public class NotaAluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;

        public double Media()
        {
            return Nota1 + Nota2 / 2;
        }

        public override string ToString()
        {
            return $"O aluno: {Nome}\nNota 1: {Nota1}\nNota 2: {Nota2}\nMédia: " + Media().ToString("f2", CultureInfo.InvariantCulture);
        }
    }


    class ProgramMediaAluno
    {
        static void Main_(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("****Teste*****");
            Console.WriteLine("______________");

            NotaAluno aluno1 = new NotaAluno();
            NotaAluno aluno2 = new NotaAluno();

            Console.Write("Nome do aluno 1: ");
            aluno1.Nome = Console.ReadLine();
            Console.Write("Informe a nota 1 do aluno: ");
            aluno1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a nota 2 do aluno : ");
            aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine(aluno1);

        }
    }
}