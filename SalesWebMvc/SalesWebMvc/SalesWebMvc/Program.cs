using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace SalesWebMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double sal = 5200;
            double percAcre = 9.0 / 100; ;
            double result = sal + (percAcre * sal);
            Console.WriteLine("Valor so salário com acrescimo R$" + result.ToString("f2", CultureInfo.InvariantCulture));
        }

     
    }
}
