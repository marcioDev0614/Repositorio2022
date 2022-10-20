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

            int s1 = Calculator.SumInt(2, 3);
            int s2 = Calculator.SumInt(4, 5, 8);
            Console.WriteLine("Metodo não recomendado: " + s1);
            Console.WriteLine("Metodo não recomendado: " + s2);

            int s3 = Calculator.SumIntVetor(new int[] { 10, 10, 2 });
            Console.WriteLine("Metodo não tão recomendado " + s3);
            int s4 = Calculator.SumIntVetorParans(15,78,78,12);
            Console.WriteLine("Resultado via metodo Params: " + s4);


            // Programa para ler um número inteiro n e a altura de n pessoas. Armazenar as N alturas
            // em um vetor. Em seguida, mostrar a altura média dessas pessoas .


            //Console.WriteLine("Preço médio do produto ");
            //Console.Write("Informe a quantidade de produtos: ");
            //int n = int.Parse(Console.ReadLine());

            //Product[] vect = new Product[n];
            //for(int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = new Product { Name = name, Price = price };
            //}

            //double sum = 0.0;
            //for(int i = 0; i < n; i++)
            //{
            //    sum += vect[i].Price;
            //}

            //double media = sum / n;
            //Console.WriteLine("AVERAGE PRICE: " + media.ToString("F2",CultureInfo.InvariantCulture));
















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
