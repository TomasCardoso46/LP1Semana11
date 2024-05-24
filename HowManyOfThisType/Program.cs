using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<object> items = new List<object>
        {
            1,
            "string",
            2.5,
            2,
            "another string",
            new object(),
            3.14,
            'a',
            true
        };

        int intCount = Checker.HowManyOfType<int>(items);
        int stringCount = Checker.HowManyOfType<string>(items);
        int doubleCount = Checker.HowManyOfType<double>(items);
        int charCount = Checker.HowManyOfType<char>(items);
        int boolCount = Checker.HowManyOfType<bool>(items);

        Console.WriteLine($"Number of integers: {intCount}");
        Console.WriteLine($"Number of strings: {stringCount}");
        Console.WriteLine($"Number of doubles: {doubleCount}");
        Console.WriteLine($"Number of chars: {charCount}");
        Console.WriteLine($"Number of booleans: {boolCount}");

        Console.WriteLine("Thank you for using this program!!!");
        
    }
}
