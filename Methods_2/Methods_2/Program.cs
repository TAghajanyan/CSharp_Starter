using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    class Program
    {

        static void InputN(out int n)
        {
            Console.Write("Please input number\nN = ");
            n = int.Parse(Console.ReadLine());
        }

        // Example of Recursion

        // Factorial

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        // Fibonacci numbers
        // Takes n and return n-th Fibonacci number
        // For example.  
        //              n=6 => Fib(6) == 8 /// 1 1 2 3 5 (8)

        static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else
            {                
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        static void Main(string[] args)
        {

            int n;
            InputN(out n);
            Console.WriteLine("n! = " + Factorial(n));

            Console.WriteLine(new string('-', 15));

            InputN(out n);
            Console.WriteLine(Fib(n));

        }
    }
}
