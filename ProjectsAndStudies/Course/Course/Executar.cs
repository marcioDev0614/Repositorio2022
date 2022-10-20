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

            Rent[] vect = new Rent[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Rent { Nome = nome, Email = email };

            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }



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
