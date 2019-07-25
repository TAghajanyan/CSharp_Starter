using System;

namespace _DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            // Format Datetime in different formats and display them  

            Console.WriteLine(dateTime.ToString("MM/dd/yyyy"));                             //  07.25.2019
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));                     //  Thursday, 25 July 2019
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));                     //  Thursday, 25 July 2019
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));                     //  Thursday, 25 July 2019
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));                     //  Thursday, 25 July 2019
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));                     //  Thursday, 25 July 2019
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss"));            //  Thursday, 25 July 2019 21:51:51
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy HH:mm"));                       //  07.25.2019 21:51
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy hh:mm tt"));                    //  07.25.2019 09:51
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy H:mm"));                        //  07.25.2019 21:51
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy h:mm tt"));                     //  07.25.2019 9:51
            Console.WriteLine(dateTime.ToString("MM/dd/yyyy HH:mm:ss"));                    //  07.25.2019 21:51:51
            Console.WriteLine(dateTime.ToString("MMMM dd"));                                //  ???? 25
            Console.WriteLine(dateTime.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK")); //  2019'-`07' -`25'T'21':'51':'51.5575671 + 04:00
            Console.WriteLine(dateTime.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));     //  ??, 25 ??? 2019 21':'51':'51 `G7T'
            Console.WriteLine(dateTime.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));          //  2019'-`07' -`25'T'21':'51':'51
            Console.WriteLine(dateTime.ToString("HH:mm"));                                  //  21:51
            Console.WriteLine(dateTime.ToString("hh:mm tt"));                               //  09:51
            Console.WriteLine(dateTime.ToString("H:mm"));                                   //  21:51
            Console.WriteLine(dateTime.ToString("h:mm tt"));                                //  9:51
            Console.WriteLine(dateTime.ToString("HH:mm:ss"));                               //  21:51:51
            Console.WriteLine(dateTime.ToString("yyyy MMMM"));                              //  2019 July

            Console.ReadKey();
        }

    }
}
