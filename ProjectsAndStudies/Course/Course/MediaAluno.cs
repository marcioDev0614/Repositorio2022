using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class MediaAluno
    {
        public class Avaliacao
        {
            public string Nome;
            public double Nota1;
            public double Nota2;

            public double Media()
            {
                return (Nota1 + Nota2) / 2;
            }

            public override string ToString()
            {
                return $"Aluno: {Nome}\nNota_1: {Nota1}\nNota_2: {Nota2}\nMédia_Final: " 
                    + Media().ToString("f2", CultureInfo.InvariantCulture);
           
            }
        }
        static void Main_(string[] args)
        {
            Console.WriteLine("****************************");
            Console.WriteLine("****Resulta_Final_Aluno*****");
            Console.WriteLine("****************************");

            Avaliacao aluno1 = new Avaliacao();

            Console.Write("Nome do aluno: ");
            aluno1.Nome = Console.ReadLine();
            Console.Write("Informe a nota 1: ");
            aluno1.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe a nota 2: ");
            aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string resultadoFinal = (aluno1.Nota1 + aluno1.Nota2) / 2 > 7 ? "Aprovado" : "Reprovado";

            Console.WriteLine(aluno1);
            Console.WriteLine(resultadoFinal);

        }
    }
}
