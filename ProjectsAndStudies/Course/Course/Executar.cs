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
            
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; // Instanciando um vetor
            for(int i = 0; i < n; i++) // Laço de repetição
            {
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            double sum = 0.0; // Criando uma variavel para acumular o vetor.
            for(int i = 0; i < n; i++)
            {
                sum += vect[i]; // recebendo o valor do vetor
            }

            double avg = sum / n;
            Console.WriteLine("AVEREGTH HEIGHT = " + avg.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
