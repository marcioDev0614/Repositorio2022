using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class AlgumasFuncoesStrings
    {

        static void Main()
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            Console.WriteLine("Original: -" + original+ "-");
            string s1 = original.ToUpper();
            Console.WriteLine("ToUpper: -" + s1 + "-"); // Convertendo tudo para maiusculo
            string s2 = original.ToLower();
            Console.WriteLine("ToLower: -" + s2 + "-"); // Convertendo tudo para minusculo
            string s3 = original.Trim();
            Console.WriteLine("Trim: -" + s3 + "-"); // Remove todos os espaços
            int n1 = original.IndexOf("bc");
            Console.WriteLine("IndexOf(bc): " + n1); // Traz o valor do indice de acordo com a primeira ocorrência da string
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("LastIndexOf(bc): " + n2); // Traz o valor do indice de acordo com a ultima ocorrência da string
            string s4 = original.Substring(3);
            Console.WriteLine("Substring(3): -" + s4 + "-");// Recorta a string a partir da posição 3
            string s5 = original.Substring(3, 5);
            Console.WriteLine("Substring(3,5): -" + s5 + "-");// Recorta a partir da posição 3, 5 caracteres
            string s6 = original.Replace('a','x');
            Console.WriteLine("Replace('a','x'): -" + s6 + "-");// Substitui o caracter por outro. Nesse casso tudo que é 'a' vira 'x'
            string s7 = original.Replace("abc","xy");
            Console.WriteLine("Replace('abc','xy'): -" + s7 + "-"); // Substitui uma string por outra. Nesse caso, "abc" por "xy"
            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine("String.IsNullOrEmpty: " + b1); // Retorna false ou true se a string é null ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("String.IsNullOrWhiteSpace: " +b2); // Testa se a variável é null ou tem vários espaços em branco
        }
    }
}
