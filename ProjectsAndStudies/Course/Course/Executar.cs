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
            Console.Write("Enntre com os valores do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.PI.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
