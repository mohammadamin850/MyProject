using System;
using System.Linq;
using System;

class Television
{
    private int channel;
    private int likedChannel;

    public Television()
    {
        channel = 0;
        likedChannel = 0;
    }

    public void Play()
    {
        bool exit = true;
        do
        {
            Console.Clear();
            Console.WriteLine($"Channel: {++channel}");
            Console.WriteLine("Do you like this channel? (YES/NO)");
            var response = Console.ReadLine().ToUpper();
            if (response == "YES")
            {
                likedChannel = channel;
            }
            exit = response == "YES" ? true : false;
        } while (!exit);

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Your favorite channel is: {likedChannel}");
        Console.Write("^_____^");
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Television tv = new Television();
        tv.Play(); 

        Console.ReadLine();
    }
}




