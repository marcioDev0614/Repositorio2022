using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Prorpiedades_TimeSpan
    {
        static void Main_()
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            
            TimeSpan t = new TimeSpan(2, 14, 15, 55);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Miliseconds: " + t.Milliseconds);
            Console.WriteLine();
            Console.WriteLine("MaxValue: " + t1);
            Console.WriteLine("MinValue: " + t2);
            Console.WriteLine("Zero: " + t3);
            Console.WriteLine();
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinuts: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            Console.WriteLine();
            // Operações com o TimeSpan

            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t4.Add(t5); // Somando t4 + t5
            TimeSpan dif = t4.Subtract(t5); // Subtraindo t4 - t5
            TimeSpan mult = t5.Multiply(2.0); // Multiplicando t4 X 2.0
            TimeSpan div = t5.Divide(2.0);


            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

        }
    }
}
