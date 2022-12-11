using System;
using System.Globalization;
using Course.Entities;
using Course;

namespace Course{
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**************");
        Console.WriteLine("****Teste*****");

        Account acc = new Account(200, "Marcio", 20.000);
        BusinessAccount bacc = new BusinessAccount(201, "Jouze", 40.000, 0.01);

        // UPCASTING

        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(203, "Neymar", 85.000, 0.01);
        Account acc3 = new SavingsAccount(204, "Amarelo", 95.00, 0.02);

        // DOWNCASTING
        // ATENÇÃO! A operação de downcasting só é recomendada é casos de extrema necessidade.
        // Também é importante realizar o teste anteriormente pois o compilador não apresenta erro em sua compilação só na execução

        //BusinessAccount acc4 = (BusinessAccount)acc2; // Sinalizar como subclasse
        //BusinessAccount acc4 = acc3 as BusinessAccount;

        //BusinessAccount acc5 = (BusinessAccount)acc3;
        if(acc3 is BusinessAccount)
        {
            BusinessAccount acc4 = acc3 as BusinessAccount;
            acc4.Loan(200.00);
            Console.WriteLine("Loan!");
        }

        if(acc3 is SavingsAccount)
        {
            SavingsAccount acc4 = (SavingsAccount)acc3;
            acc4.UpdateBalance();
            Console.WriteLine("Update!");
        }
    }
}

