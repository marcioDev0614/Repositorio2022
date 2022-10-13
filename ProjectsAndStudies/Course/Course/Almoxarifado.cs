using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Almoxarifado
    {
        public int IDProduto { get; private set; }
        public string Produto { get; set; }
        public double SaldoEstoque { get; private set; }

        public Almoxarifado() { }

        public Almoxarifado(int iDProduto, string produto)
        {
            IDProduto = iDProduto;
            Produto = produto;
        }

        public Almoxarifado(int iDProduto, string produto, double saldoEstoque) : this(iDProduto, produto)
        {
            SaldoEstoque = saldoEstoque;
        }

        public void AdicionarProduto(double qtd)
        {
            SaldoEstoque += qtd;
        }

        public void RemoverProduto(double qtd)
        {
            SaldoEstoque -= qtd;
        }

        public override string ToString()
        {
            return $"Id_Produto: {IDProduto}, Produto: {Produto}, SaldoEstoque: " 
            + SaldoEstoque.ToString("f2", CultureInfo.InvariantCulture);
        }
        static void Main()
        {
            Almoxarifado produto;

            Console.Write("Informe o código do produto: ");
            int idproduto = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá inserção de quantidade de produto (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor quantitativo inicial: ");
                double qtd = int.Parse(Console.ReadLine());
                produto = new Almoxarifado(idproduto, nome, qtd);
            }
            else
            {
                produto = new Almoxarifado(idproduto, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados do estoque: ");
            Console.WriteLine(produto);

            Console.WriteLine();
            Console.Write("Entre com o valor a ser inserido ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.AdicionarProduto(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(produto);

            Console.WriteLine();
            Console.Write("Entre com o valor a ser removido: ");
            quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            produto.RemoverProduto(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(produto);
        }
    }
  
}
