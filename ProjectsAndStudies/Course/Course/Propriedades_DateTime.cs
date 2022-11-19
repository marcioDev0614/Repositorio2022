using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Propriedades_DateTime
    {
        static void Main_()
        {
            DateTime d = new DateTime(2022, 11, 16, 18, 36, 55, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) Month: " + d.Month);
            Console.WriteLine("4) Hours: " + d.Hour);
            Console.WriteLine("5) Secounds: " + d.Second);
            Console.WriteLine("6) Minutes: " + d.Minute);
            Console.WriteLine("7) Milliseconds: " + d.Millisecond);
            Console.WriteLine("8) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("9) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("10) Kind: " + d.Kind);
            Console.WriteLine("11) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("12: Year: " + d.Year);

            DateTime d1 = new DateTime(2022, 11, 16, 18, 47, 25);

            string s1 = d1.ToLongDateString();
            string s2 = d1.ToLongTimeString();
            string s3 = d1.ToShortDateString();
            string s4 = d1.ToShortTimeString();
            string s5 = d1.ToString();
            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss");
          
          
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);

            DateTime d2 = d1.AddHours(2);
            DateTime d3 = d1.AddMinutes(135);
            Console.WriteLine();
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine();
            Console.WriteLine(d1);
            Console.WriteLine(d3);
            DateTime d4 = d1.AddDays(7);
            Console.WriteLine("Vencimento do Boleto:  " + d4);

            DateTime data1 = new DateTime(2022,11,17,11,00,55);
            Console.WriteLine(data1);
            DateTime sgo = data1.AddDays(5);
            Console.WriteLine(sgo);
            DateTime sgoRetomada = sgo.AddHours(2);
            Console.WriteLine(sgoRetomada);
            TimeSpan dif = sgo.Subtract(sgoRetomada);
            Console.WriteLine(dif);



        }
    }
}
