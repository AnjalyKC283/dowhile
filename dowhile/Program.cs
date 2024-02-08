using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, n;
            Console.WriteLine("enter limit:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("even numbers are:");
            do
            {
                a = a + 2;
                Console.WriteLine(a);
            }
            while (a <= n);
            Console.ReadKey();
        }
    }
}
