using System;
using System.Linq;

namespace Mr.Mohammd
{
    class name
    {
        static void Main(string[] args)
        {



            Console.Clear();
            while (true)

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("***WELLCOM***");
                Console.WriteLine("Choose your topic: ");
                Console.WriteLine("1} Letters and numbers");
                Console.WriteLine("2} Days of the Week");
                Console.WriteLine("3_Exit");
                Console.Write("-->");
                Console.ResetColor();

                var user = Console.ReadLine();

                if (user == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Choose a number between 1 to 10:");
                    var number = Console.ReadLine();
                    switch (number)
                    {
                        case "1":
                            Console.WriteLine("the result is: one");
                            break;
                        case "2":
                            Console.WriteLine("the result is: two");
                            break;
                        case "3":
                            Console.WriteLine("the result is: three");
                            break;
                        case "4":
                            Console.WriteLine("the result is: four");
                            break;
                        case "5":
                            Console.WriteLine("the result is: five");
                            break;
                        case "6":
                            Console.WriteLine("the result is: six");
                            break;
                        case "7":
                            Console.WriteLine("the result is: seven");
                            break;
                        case "8":
                            Console.WriteLine("the result is: eight");
                            break;
                        case "9":
                            Console.WriteLine("the result is: nine");
                            break;
                        case "10":
                            Console.WriteLine("the result is: ten");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.WriteLine("The number you entered is out of range!!");
                            break;
                    }
                    Console.ReadKey();
                }
                if (user == "2")
                {
                    Console.Clear();
                    Console.WriteLine("enter your day 1 to 7 : ");
                    var day = Console.ReadLine();
                    switch (day)
                    {
                        case "1":
                            Console.WriteLine("today is: Saturday");
                            break;
                        case "2":
                            Console.WriteLine("today is: sunday");
                            break;
                        case "3":
                            Console.WriteLine("today is: monday");
                            break;
                        case "4":
                            Console.WriteLine("today is: Tuesday");
                            break;
                        case "5":
                            Console.WriteLine("today is: Wednesday");
                            break;
                        case "6":
                            Console.WriteLine("today is: Thursday");
                            break;
                        case "7":
                            Console.WriteLine("today is: Firday");
                            break;
                        default:
                            Console.WriteLine("The date you entered is incorrect");
                            break;
                    }
                    Console.ReadKey();
                }
                if (user != "1" && user != "2" && user != "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("The number you entered is incorrect.\nPlease try again.");
                    Console.ReadKey();
                }

                if (user == "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("—–> Good bye ByBe");
                    Console.WriteLine("seeyou💋");
                    break;
                }
            }

        }
    }
}