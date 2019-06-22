using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Conditional Statements "if-else"

            // if-else Example

            int x = 2;
            if (x > 3)
            {
                Console.WriteLine("x is greater than 3");
            }
            else
            {
                Console.WriteLine("x is not greater than 3");
            }


            // Nested "if" Statements – Example

            int first = 5;
            int second = 3;
            if (first == second)
            {
                Console.WriteLine("These two numbers are equal.");
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine("The first number is greater.");
                }
                else
                {
                    Console.WriteLine("The second number is greater.");
                }
            }
            // Console output
            // The first number is greater.


            // Sequences of "if-else-if-else-…"

            char ch = 'X';
            if (ch == 'A' || ch == 'a')
            {
                Console.WriteLine("Vowel [ei]");
            }
            else if (ch == 'E' || ch == 'e')
            {
                Console.WriteLine("Vowel [i:]");
            }
            else if (ch == 'I' || ch == 'i')
            {
                Console.WriteLine("Vowel [ai]");
            }
            else if (ch == 'O' || ch == 'o')
            {
                Console.WriteLine("Vowel [ou]");
            }
            else if (ch == 'U' || ch == 'u')
            {
                Console.WriteLine("Vowel [ju:]");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            // Console output
            // Consonant




            // Conditional Statement "switch-case"

            // Using Multiple Labels

            int number = 10;
            switch (number)
            {
                case 1:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("The number is not prime!"); break;
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("The number is prime!"); break;
                default:
                    Console.WriteLine("Unknown number!"); break;
            }
            // Console output
            // The number is not prime! 


        }
    }
}
