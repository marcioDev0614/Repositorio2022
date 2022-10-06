using System;
using System.Globalization;

namespace Course
{
    public class Cadastro
    {
        public string Nome;
        public int Idade;
    }
    class ExeCadastro
    {
        static void Main_(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("****Teste*****");

            Cadastro pessoa1 = new Cadastro();
            Cadastro pessoa2 = new Cadastro();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }

        }
    }
}

