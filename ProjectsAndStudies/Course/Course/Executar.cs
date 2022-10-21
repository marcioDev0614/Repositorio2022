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
            // Laço foreach - sintaxe opcional e simplificada para percorrer coleções

            string[] vect = new string[] { "Marcio", "Jouze" };
            foreach(var nomes in vect) // 
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("--------------------------");

            for(int i = 0; i < vect.Length; i++) // Mesmo resultado do foreach usand o for
            {
                Console.WriteLine(vect[i]);
            }



        }
    }
}
