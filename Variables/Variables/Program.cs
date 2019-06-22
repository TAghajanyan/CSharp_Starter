using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic data types in C#: 

            // - Integer types – sbyte, byte, short, ushort, int, uint, long, ulong;
            // - Real floating - point types – float, double;
            // - Real type with decimal precision – decimal;
            // - Boolean type – bool;
            // - Character type – char;
            // - String – string;
            // - Object type – object.

            /////////////////////////////////////////////////////////////////////

            //Integer Types – Example

            // Declare some variables
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;
            
            // Print the result on the console 
            Console.WriteLine(centuries + " centuries are " + years + 
                " years, or " + days + " days, or " + hours + " hours.");
            
            // Console output:
            // 20 centuries are 2000 years, or 730480 days, or 17531520 
            // hours.

            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine(maxIntValue); // 18446744073709551615

            

            // Real Floating-Point Types – Example

            float floatPI = 3.14f;
            Console.WriteLine(floatPI);// 3.14 

            double doublePI = 3.14; 
            Console.WriteLine(doublePI); // 3.14 

            double nan = Double.NaN;
            Console.WriteLine(nan); // NaN 

            double positiveInfinity = Double.PositiveInfinity;
            Console.WriteLine(positiveInfinity); // Positive infinity

            float negativeInfinitya = Single.NegativeInfinity;
            Console.WriteLine(negativeInfinitya); // Negative infinity




            //Boolean Type

            int a = 1;
            int b = 2;
            // Which one is greater?
            bool greaterAB = (a > b); // greaterAB == false
            // Is 'a' equal to 1? 
            bool equalA1 = (a == 1); // equalA1 == true
            // Print the results on the console
            if (greaterAB)
            {
                Console.WriteLine("A > B");
            }
            else
            {
                Console.WriteLine("A <= B");
            }
            Console.WriteLine("greaterAB = " + greaterAB);
            Console.WriteLine("equalA1 = " + equalA1);
            // Console output: 
            // A <= B 
            // greaterAB = False
            // equalA1 = True



            // Character Type

            // Declare a variable
            char ch = 'a';
            // Print the results on the console
            Console.WriteLine( "The code of '" + ch + "' is: " + (int)ch);
            ch = 'b';
            Console.WriteLine( "The code of '" + ch + "' is: " + (int)ch);
            ch = 'A';
            Console.WriteLine( "The code of '" + ch + "' is: " + (int)ch);

            // Console output:
            // The code of 'a' is: 97
            // The code of 'b' is: 98 
            // The code of 'A' is: 65




            // Strings

            // Declare some variables 
            string firstName = "John";
            string lastName = "Smith";
            string fullName = firstName + " " + lastName;
            
            // Print the results on the console 
            Console.WriteLine("Hello, " + firstName + "!");
            Console.WriteLine("Your full name is " + fullName + ".");

            // Console output: 
            // Hello, John! 
            // Your full name is John Smith.



            // Object Type

            // Declare some variables 
            object container1 = 5;
            object container2 = "Five";
            
            // Print the results on the console 
            Console.WriteLine("The value of container1 is: " + container1);
            Console.WriteLine("The value of container2 is: " + container2);

            // Console output:
            // The value of container1 is: 5
            // The value of container2 is: Five.



            // Nullable Types

            int i = 5;
            int? ni = i;
            Console.WriteLine(ni); // 5

            // i = ni; // this will fail to compile 
            Console.WriteLine(ni.HasValue); // True 
            i = ni.Value;
            Console.WriteLine(i); // 5

            ni = null;
            Console.WriteLine(ni.HasValue); // False 
            //i = ni.Value; // System.InvalidOperationException
            i = ni.GetValueOrDefault();
            Console.WriteLine(i); // 0

        }
    }
}
