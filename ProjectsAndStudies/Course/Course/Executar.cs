using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Executar
    {
        static void Main()
        {

            // Programa para ler um número inteiro n e a altura de n pessoas. Armazenar as N alturas
            // em um vetor. Em seguida, mostrar a altura média dessas pessoas .


            Console.WriteLine("Descobrir a média final do aluno: ");
            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write($"Informe a quantidade de notas : ");
            int qtdNotas = int.Parse(Console.ReadLine());

            double[] notas = new double[qtdNotas];

            for(int i = 0; i < qtdNotas; i++)
            {
                Console.Write($"Nota: {i}: ");
                notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }

            double sumNotas = 0.0;
            for(int i = 0; i < qtdNotas; i++)
            {
                sumNotas += notas[i];
            }

            double media = sumNotas / 3;
            string result = media >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine();
            Console.WriteLine($"Aluno: {nome}\nMédia: " + media.ToString("f2",CultureInfo.InvariantCulture) 
                                +"\nResultado Final: " + result);
            
            //Console.WriteLine("Programa para ler a média de altura");
            //int n = int.Parse(Console.ReadLine());
            //double[] vect = new double[n];

            //for(int i = 0; i < n; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double sum = 0.0;
            //for(int i = 0; i < n; i++)
            //{
            //    sum += vect[i];
            //}

            //double avg = sum / n;
            //Console.WriteLine("Média: " + avg.ToString("f2",CultureInfo.InvariantCulture));

        }
    }
}
