using System;

namespace _DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            // Format Datetime in different formats and display them  
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy"));
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy H:mm"));
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy h:mm tt"));
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine(dateTime.ToString("MMMM dd"));
            Console.WriteLine(dateTime.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));
            Console.WriteLine(dateTime.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
            Console.WriteLine(dateTime.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
            Console.WriteLine(dateTime.ToString("HH:mm"));
            Console.WriteLine(dateTime.ToString("hh:mm tt"));
            Console.WriteLine(dateTime.ToString("H:mm"));
            Console.WriteLine(dateTime.ToString("h:mm tt"));
            Console.WriteLine(dateTime.ToString("HH:mm:ss"));
            Console.WriteLine(dateTime.ToString("yyyy MMMM"));

            Console.ReadKey();
        }

    }
}
