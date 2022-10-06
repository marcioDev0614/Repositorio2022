using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    public class Triangulo
    {

        public double A;
        public double B;
        public double C;

        public double Area() // Metodo criado para facilitar e refatorar o código.
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
           //return raiz;
        }

    }

    class ProblemaComOO
    {
        static void Main()
        {


            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area(); // Chamando o metodo Area() criado dentro da classe.

            double areaY = y.Area();

            Console.WriteLine("área de X = " + areaX.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("f2", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}

