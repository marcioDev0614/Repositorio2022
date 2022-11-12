using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class ConsumoTinta
    {
        public class AreaPintura
        {
            public double Largura;
            public double Altura;

            public double QtdTinta()
            {
                return (Largura * Altura) / 2;
            }

            public double Area()
            {
                return Largura * Altura;
            }
            public override string ToString()
            {
                return $"Largura: {Largura}\nAltura: {Altura}\nÁrea: " 
                    + Area().ToString("f2", CultureInfo.InvariantCulture)+"\nQtd Tinta: "
                    + QtdTinta().ToString("f2", CultureInfo.InvariantCulture)+" litros";
            }
        }
        static void Main_(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("    Consumo de Tinta   ");
            Console.WriteLine("***********************");

            AreaPintura area = new AreaPintura();

            Console.Write("Informe a largura da parede: ");
            area.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe a altura da parede: ");
            area.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(area);

        }
    }
}

