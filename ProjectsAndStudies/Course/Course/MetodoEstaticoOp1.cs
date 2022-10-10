using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class MetodoEstaticoOp1
    {
        static double PI = 3.14;
        static void Main()
        {
            Calculadora calc = new Calculadora();
            
            Console.Write("Entre com o valor de rario: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.PI.ToString("f2", CultureInfo.InvariantCulture));
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * r * r * r;
        }

        static double Circunferencia(double r)
        {
            return 2.0 * PI * r;
        }
    }
}
