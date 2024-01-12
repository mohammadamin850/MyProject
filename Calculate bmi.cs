using System;
using System.Globalization;

namespace BMICalculator
{
    class Program
    {
        // نقطه ورود برنامه
        static void Main(string[] args)
        {
            if (!ValidateArguments(args))
            {
                return;
            }

            switch (args[0])
            {
                case "--help":
                    ShowHelp();
                    break;
                case "--version":
                    ShowCurrentVersion();
                    break;
                case "bmi":
                    if (args.Length < 5)
                    {
                        BadCommand();
                        return;
                    }
                    ExecuteCommands(args);
                    break;
                default:
                    BadCommand();
                    break;
            }
        }

        // بررسی اعتبار ورودی‌ها
        static bool ValidateArguments(string[] args)
        {
            if (args.Length == 0 & (args[0] != "bmi" && args[0] != "--help" && args[0] != "--version"))
            {
                BadCommand();
                return false;
            }
            return true;
        }

        // اجرا کردن دستورات بر اساس ورودی‌ها
        static void ExecuteCommands(string[] args)
        {
            string heightSwitch = args[1];
            string weightSwitch = args[3];
            double height, weight;

            if ((heightSwitch == "--height" && double.TryParse(args[2], NumberStyles.Any, CultureInfo.InvariantCulture, out height)) &&
                (weightSwitch == "--weight" && double.TryParse(args[4], NumberStyles.Any, CultureInfo.InvariantCulture, out weight)))
            {
                CalculateBmi(height, weight);
            }
            else
            {
                BadCommand();
            }
        }

        // نمایش راهنما
        static void ShowHelp()
        {
            Console.WriteLine("\nUse these switches to run the program:");
            Console.WriteLine("bmi --height <Your height in meters> --weight <Your weight in kilograms>");
            Console.WriteLine("--version\tShow current version");
            Console.WriteLine("--help\t\tShow command list and usage");
        }

        // نمایش پیام خطا برای دستورات نامعتبر
        static void BadCommand()
        {
            Console.WriteLine("\nInvalid command :(");
            Console.WriteLine("Use --help switch for guidance");
        }

        // محاسبه و نمایش BMI
        static void CalculateBmi(double height, double weight)
        {
            double bmi = weight / (height * height);
            Console.WriteLine($"Your BMI is: {bmi:F2}");

            string status = bmi switch
            {
                <= 18.4 => "Underweight",
                < 25 => "Normal",
                < 30 => "Overweight",
                _ => "Obese"
            };

            Console.WriteLine($"According to BMI, you are: {status}");
        }

        // نمایش نسخه فعلی برنامه
        static void ShowCurrentVersion()
        {
            Console.WriteLine("\nCurrent version is: 1.0");
        }
    }
}