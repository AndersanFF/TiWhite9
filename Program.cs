using System;
using System.Threading;


namespace _123456789
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 7;
            int b = 1000;
            Console.WriteLine("* хруст пальцев");
            Console.WriteLine("я гуль");
            for (int c = 0; b > -1;c--)
            {
                b = b - a;
                Console.WriteLine(b);
                Thread.Sleep(50);
            }
            if (b <= 0)
                Console.WriteLine("Let me die");
            Console.ReadKey();
        }
       
    }
   
}
