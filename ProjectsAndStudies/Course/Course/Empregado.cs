using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Empregado() { }

        public Empregado(int id, string nome, string cpf, string email, double salario)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Salario = salario;
        }

        public override string ToString()
        {
            return "Id: " 
                + Id + ", Nome: " 
                + Nome + ", Cpf: " 
                + Cpf + ", Email: " 
                + Email + ", Salário R$: " 
                + Salario.ToString("f2", CultureInfo.InvariantCulture);
        }

        public void AlmentoSalarioPorcentagem(double poncentagem)
        {
            Salario = Salario + (Salario * poncentagem / 100.0);
        }

        static void Main()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("Cadastro de Empregados.");
            Console.WriteLine("     Versão: 1.0       ");
            Console.WriteLine("***********************");
            Console.WriteLine();

            Console.Write("Quantos empregado serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Empregado> empregado = new List<Empregado>();
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Empregado #{i}");
                Console.Write("Informe o Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o cpf: ");
                string cpf = Console.ReadLine();
                Console.Write("Informe o email: ");
                string email = Console.ReadLine();
                Console.Write("Informe o salário: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                empregado.Add(new Empregado(id, nome, cpf,email,salario));
            }

            Console.WriteLine();
            Console.Write("Informe o id do empregado que receberá o ajuste: ");
            int procureId = int.Parse(Console.ReadLine());

            Empregado emp = empregado.Find(x => x.Id == procureId);
          if(emp != null)
            {
                Console.Write("Porcentagem a ser acrescentada ao salário: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AlmentoSalarioPorcentagem(porcentagem);
            }
            else
            {
                Console.WriteLine("Id não existe. Favor informa um registro válido.");
            }

            Console.WriteLine();
            Console.WriteLine("Informação atualizada: ");
            foreach(Empregado obj in empregado)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
