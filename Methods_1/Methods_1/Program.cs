using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_1
{
    class Program
    {

        // Simple method example
        // Void type
        static void PrintLogo()
        {
            Console.WriteLine("Microsoft");
            Console.WriteLine("www.microsoft.com");
        }


        // Method with parameters
        // Double type
        static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        // Void type
        static void Print(int sum, string text)
        {
            Console.WriteLine(text + sum);
        }


        // Method Overloading {
        static void Draw(string str)
        {
            Console.WriteLine(str);
        }

        static void Draw(int number)
        {
            Console.WriteLine(number);
        }

        static void Draw(bool b)
        {
            Console.WriteLine(b);
        }
        // }


        // Method with defoult param
        static void PrintFullName(string fName, string lName, string title = "student")
        {
            Console.WriteLine("I'm " + title + " my name is " + fName + " " + lName);
        }


        //ref & out
        // ref variable must be initialized before use.
        // out variable can be used without assignment.

        // params by reference

        static int GetSum(ref int n1, ref int n2)
        {
            int sum = n1 + n2;
            n1 = 0;
            n2 = -1;
            return sum;
        }


        // Example TryParse function
        // Param by reference
        static bool TryParse(string s, out int result)
        {
            try
            {
                result = int.Parse(s);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }

        static void Main(string[] args)
        {

            PrintLogo();

            GetRectangleArea(12, 10);

            Print(15, "Sum is: ");

            // Takes string type
            Draw("Hello");

            // Takes integer type
            Draw(155);

            // Takes boolean type
            Draw(true);

            //third param is "student"
            PrintFullName("Steve", "Jobs");
            //third param is "Singer"
            PrintFullName("Elton", "John", "singer");


            // Example with ref 
            int n1 = 4;
            int n2 = 5;
            Console.WriteLine(n1 + "/n" + n2);
            GetSum(ref n1, ref n2);
            Console.WriteLine(n1 + "/n" + n2);


            // Example with out
            int result;

            bool b = TryParse(Console.ReadLine(), out result);
            Console.WriteLine(b + "/n" + result);

        }
    }
}
