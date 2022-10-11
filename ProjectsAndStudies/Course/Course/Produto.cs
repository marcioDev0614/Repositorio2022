using System;
using System.Globalization;

namespace Course
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { } // Construtor padrão

        public Produto(string nome, double preco, int quantidade) // Contrutor com argumentos
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public int AdicionarProdutos(int quantidade)
        {
            return Quantidade += quantidade;
        }

        public int RemoverProdutos(int quantidade)
        {
            return Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("f2",CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $"
            + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("****Teste*****");

            //Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome,preco,quantidade);

            Console.WriteLine($"Dados do Produto: {produto}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");



        }
    }
}

