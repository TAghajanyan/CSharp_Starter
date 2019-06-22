using System;
using System.Numerics;

namespace Loops
{
    class Program 
    {
        static void Main(string[] args)
        {

            //while (condition) //Condition is returns a Boolean result - true or false
            //{
            //    loop body;
            //}

            //Using of While Loops

            // Initialize the counter
            int counter = 0;

            // Execute the loop body while the loop condition holds
            while (counter < 10)
            {
                // Print the counter value
                Console.WriteLine("Number : " + counter);
                // Increment the counter
                counter++;
            }

            // Summing the Numbers from 1 to N

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;
            Console.Write("The sum: 1 ");
            while (num < n) //The number n is read from the consol:
            {
                num++;
                sum += num;
                Console.Write(" + " + num);
            }
            Console.WriteLine(" = " + sum);
            // For example n = 5
            // The sum: 1 + 2 + 3 + 4 + 5 = 15

            // Calculating Factorial - Example

            Console.Write("Please input number\nm = ");
            int m = int.Parse(Console.ReadLine());
            // <decimal> is the biggest C# type that can hold integer values
            decimal factorial = 1;
            // Perform an "infinite loop"
            while (true)
            {
                if (m <= 1)
                    break;

                factorial *= m;
                m--;
            }
            Console.WriteLine("m! = " + factorial);
            // For example n = 5
            // The sum: 1 * 5 * 4 * 3 * 2 = 120

            ////////////////////////////////////////////////////////////////

            // { do-while }
            // Calculating Factorial of a Large Number - Example
            // For example 100. If we try to calculate 100! we will overflow the decimal type
            //                  For this, we can use data type <BigInteger>
            //For using BigInteger, we must first add a reference from our project to the assembly System.Numerics.dll

            Console.Write("n = ");
            int t = Convert.ToInt32(Console.ReadLine());
            BigInteger bigFactorial = 1;
            do
            {
                bigFactorial *= t;
                t--;
            } while (t > 0);

            Console.WriteLine("n! = " + bigFactorial);
            Console.ReadKey();

            ////////////////////////////////////////////////////////////////

            // For, Foreach and Nested loops

            // for(initialization; condition; updata)
            // {
            //    loop's body;
            // }

            // infinite loop

            //for(; ; )
            //{
            //    // loop body;
            //}

            //For-Loop – Examples
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }
            //Result -> 0 1 2 3 4 5 6 7 8 9

            for (int i = 0, sum1 = 1 ; i < 20; i++, sum1 +=i)
            {
                Console.WriteLine("i={0},  sum={1}",i,sum);
            }

            // Calculating N^ M – Example

            Console.Write("n = ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("m = ");                        // n = 2       
            int m1 = int.Parse(Console.ReadLine());       // m = 10      
            decimal result = 1;                           // n ^ m = 1024      
            for (int i = 0; i < m; i++)                  
            {                                         
                result *= n;
            }
            Console.WriteLine("n^m = " + result); 


            //Foreach loops
            // foreach (type variable in collection)
            // {
            //     statements;
            // }

            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine();

            string[] towns = { "London", "Paris", "Milan", "New York" };
            foreach (string town in towns)
            {
                Console.Write(" " + town);
            }

            // 2 3 5 7 11 13 17 19
            // London Paris Milan New York

            ////////////////////////////////////////////////////////////////

            // Nested Loops

            //Printing a Triangle – Example
            int n2 = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n2; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            //Result:
            // 1
            // 1 2
            // 1 2 3
            // 1 2 3 4
            // 1 2 3 4 5
            // 1 2 3 4 5 6
            // 1 2 3 4 5 6 7


        }
    }
}
