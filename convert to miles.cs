using System;
using System.Linq;

namespace Mr.Mohammd
{
    class name
    {
        static void Main(string[] args)
        {



            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("convert mile to kilometers mile");
            Console.WriteLine("exit");
            var mile = Convert.ToDouble(Console.ReadLine());
            var kilometers = mile * 1.6039;
            Console.WriteLine(kilometers);
          



        }
    }
}