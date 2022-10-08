using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return $"Área: " + Area().ToString("f2",CultureInfo.InvariantCulture)
            +"\nPerimetro: " + Perimetro().ToString("f2",CultureInfo.InvariantCulture)
            +"\nDiagonal: " + Diagonal().ToString("f2",CultureInfo.InvariantCulture);
        }

        static void Main_()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("Calcular a Largura e Altura do Triangulo");
            Console.WriteLine("****************************************");
            Console.WriteLine();

            Retangulo p = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            p.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(p);
        }
    }
}
