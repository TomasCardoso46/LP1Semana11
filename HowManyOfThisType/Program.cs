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
            new object()
        };

        int intCount = Checker.HowManyOfType<int>(items);
        int stringCount = Checker.HowManyOfType<string>(items);

        Console.WriteLine($"Number of integers: {intCount}");
        Console.WriteLine($"Number of strings: {stringCount}");
    }
}
