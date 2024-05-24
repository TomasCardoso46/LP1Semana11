// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> intList = new List<int> { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
        int intCompare = 6;
        IEnumerable<int> intResults = BeforeUtils.GetTheOnesBefore(intList, intCompare);

        Console.WriteLine("Integers before 6:");
        foreach (var item in intResults)
        {
            Console.WriteLine(item);
        }

        
        List<DateTime> dateList = new List<DateTime>
        {
            new DateTime(2022, 1, 1),
            new DateTime(2021, 5, 15),
            new DateTime(2023, 7, 23),
            new DateTime(2020, 12, 31)
        };
        DateTime dateCompare = new DateTime(2022, 1, 1);
        IEnumerable<DateTime> dateResults = BeforeUtils.GetTheOnesBefore(dateList, dateCompare);

        Console.WriteLine("\nDates before 2022-01-01:");
        foreach (var item in dateResults)
        {
            Console.WriteLine(item.ToShortDateString());
        }
    }
}
