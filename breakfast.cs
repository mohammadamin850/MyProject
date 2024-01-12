using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MMD
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Clear();
          
            var Print = new Stopwatch();
            Print.Start();
            
            // Await the asynchronous methods
            await coffee();
            await Toaster();
            await juice();
            await BrakeFasts();

            Print.Stop();
            Console.WriteLine(Print.ElapsedMilliseconds + "ms");
        } 

        public static async Task coffee()
        {
            await Task.Run(() =>
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Pouring Coffee");
                Console.ResetColor();
                Thread.Sleep(2000); // Consider using Task.Delay(2000) in async methods instead of Thread.Sleep

                // The following lines seem misplaced here and should probably be in another method
                Console.WriteLine("Warming the egg pan...");
                Console.WriteLine("Cooking first side of bacon...");
                Thread.Sleep(500); // Task.Delay(500)
                Console.WriteLine("Putting a slice of bread in the toaster");
                Console.WriteLine("Putting a slice of bread in the toaster");
            });
        }

        public static async Task Toaster()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(400); // Task.Delay(400)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Start toasting...");
                Console.ResetColor();
                Thread.Sleep(600); // Task.Delay(600)

                Console.WriteLine("Remove toast from toaster");
                // The following lines seem to be repetitive and possibly in the wrong place
                Console.WriteLine("Flipping a slice of bacon");
                Console.WriteLine("Flipping a slice of bacon");
                Console.WriteLine("Flipping a slice of bacon");
                Console.WriteLine("Cooking the second side of bacon...");
                Console.WriteLine("Putting jam on the toast");
                Console.WriteLine("Toast is ready");
                Thread.Sleep(200); // Task.Delay(200)
            });
        }

        public static async Task juice()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000); // Task.Delay(1000)
            
                Console.WriteLine("Put bacon on plate");
                Console.WriteLine("Bacon is ready");
                Console.WriteLine("Pouring orange juice");
                Console.WriteLine("Juice is ready");
            });
        }

        static async Task BrakeFasts()
        {
            await Task.Run(() =>
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Breakfast is ready");
                Console.ResetColor();
                Console.ReadKey();
            });
        }
    }
}