using System;


namespace Rectangle_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice1;
            int choice2;

            do
            {
                do
                {
                    Console.WriteLine("1 - Rectangle");
                    Console.WriteLine("2 - Triangle");
                    Console.Write("Choice -> ");
                    choice1 = int.Parse(Console.ReadLine());
                    if (choice1 > 2 || choice1 < 1) Console.WriteLine("Unknown choice, please try again!");
                } while (choice1 > 2 || choice1 < 1);

                Console.Write("Height = "); int h = int.Parse(Console.ReadLine());
                Console.Write("Width = "); int w = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("1 - Area");
                    Console.WriteLine("2 - Perimeter");
                    Console.WriteLine("3 - Draw");
                    Console.WriteLine("0 - Exit");

                    Console.Write("Choice -> ");
                    choice2 = int.Parse(Console.ReadLine());

                    if (choice2 > 3 || choice2 < 0) Console.WriteLine("Unknown choice, please try again");
                    if (choice2 == 0)
                        break;

                } while (choice2 > 3 || choice2 < 0);
                switch (choice1)
                {
                    case 1:
                        {
                            Rectangle r = new Rectangle(h, w);
                            switch (choice2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Area = " + r.Area);
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.WriteLine("Perimeter = " + r.Perimeter);
                                        break;
                                    }
                                case 3:
                                    {
                                        r.Draw();
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        Triangle t = new Triangle(h, w);
                        switch (choice2)
                        {
                            case 1:
                                Console.WriteLine("Area = " + t.Area);
                                break;

                            case 2:
                                Console.WriteLine("Perimeter = " + t.Perimeter);
                                break;

                            case 3:
                                t.Draw();
                                break;
                        }
                        break;
                }
                Console.WriteLine();

            } while (true);

        }
    }
}
