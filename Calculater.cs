using System;

class Program
{
    static void Main(string[] args)
    {
        Calculater calculater = new Calculater();
        Console.Clear();
        Console.WriteLine("__________");
        Console.WriteLine("Calculater Program");
        Console.WriteLine("__________");

        SetCalculaterOperators(calculater);

        calculater.printOptions();

        while (true)
        {
            calculater.Oprand = Console.ReadLine();
            try
            {
                calculater.Process();
                Console.WriteLine(calculater);
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Would you like to play again? (Y = YES), (N = NO)");
        }

        Console.WriteLine("BYE!");
    }

    private static void SetCalculaterOperators(Calculater calculater)
    {
        Console.WriteLine("Enter number 1: ");
        calculater.FirstNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number 2: ");
        calculater.SecundNumber = Convert.ToDouble(Console.ReadLine());
    }
}

public class Calculater
{
    public double FirstNumber { get; set; }
    public double SecundNumber { get; set; }
    public double Result { get; set; }
    private string _operand;
    public string Oprand
    {
        set
        {
            if (value == "*" || value == "-" || value == "+" || value == "/")
            {
                _operand = value;
            }
        }
    }

    public void Process()
    {
        switch (_operand)
        {
            case "*":
                Result = FirstNumber * SecundNumber;
                break;
            case "-":
                Result = FirstNumber - SecundNumber;
                break;
            case "+":
                Result = FirstNumber + SecundNumber;
                break;
            case "/":
                Result = FirstNumber / SecundNumber;
                break;
            default:
                throw new Exception("That was not a valid option");
        }
    }

    public override string ToString()
    {
        return $"Your Result: {FirstNumber} {_operand} {SecundNumber} = {Result}";
    }

    public void printOptions()
    {
        Console.WriteLine("Options :");
        Console.WriteLine("\t + ");
        Console.WriteLine("\t - ");
        Console.WriteLine("\t * ");
        Console.WriteLine("\t / ");
        Console.WriteLine("Enter an option");
    }
}