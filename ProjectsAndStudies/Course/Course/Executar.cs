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
            Point p;
            p.X = 10; // Na declaração de uma struct, não é obrigado usar a "new". Mas também é uma sintaxe aceitável
            p.Y = 20;
            Console.WriteLine(p); // Não será possível a impressão pois no struct o valor deve ser inicializado na variével
            p = new Point();
            Console.WriteLine(p); // Nesse exemplo o valor será zerado pois os valores iniciam com o valor padrão.

         
        }
    }
}
