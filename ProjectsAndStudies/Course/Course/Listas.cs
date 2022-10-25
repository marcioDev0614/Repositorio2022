using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Course
{
    class Listas
    {
        static void Main()
        {
            // Lista é uma estrutura de dados
            // Homogênea (dados do mesmo tipo)
            // Ordenada(Elementos acessados por meio de posições)
            // Inicia vazia, e seus elementos são alocados sob demanda

            // Classe: List
            // Namespace: System.Collection.Generic

            // Sintaxe de list já instanciando os elementos.

            List<string> list = new List<string> { "Maria", "Alex", "Bob", "Anna" };
            list.Insert(2, "Marco"); // Inserindo a string numa determinada posição.


            foreach (var obj in list) // Percorrer toda a lista com o foreach
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A'); // Exemplo de metodo usando expressão lambda
            Console.WriteLine("Firts A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); // Ultimo elemento da lista
            Console.WriteLine("Find last A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Fisrt position 'A': " + pos1); // Posição do elemento na lista

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // Ultima posição index da lista
            Console.WriteLine("Last index position: 'A': " + pos2);

            // Sintaxe para encontrar todos os elementos de tamanho 5
            List<string> lis2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------------");
            foreach(var obj in lis2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex"); // Removendo um elemento da lista
            Console.WriteLine("-------------------------");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');// Removendo todos os elementos que começam com a letra "M"
            Console.WriteLine("-------------------------");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
