using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class E_TimeSpan
    {
        static void Main()
        {
            
            TimeSpan t1 = new TimeSpan(1,33,25);
            TimeSpan t2 = new TimeSpan(2, 5, 0, 0);
            TimeSpan t3 = new TimeSpan(5, 8, 30, 55, 25);
            TimeSpan t4 = new TimeSpan();
            TimeSpan t5 = TimeSpan.FromDays(1.5);
            TimeSpan t6 = TimeSpan.FromHours(1.5);
            TimeSpan t7 = TimeSpan.FromSeconds(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromMilliseconds(1.5);


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
        }
    }
}
