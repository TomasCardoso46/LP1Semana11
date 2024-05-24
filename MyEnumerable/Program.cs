using System;

class Program
{
    static void Main(string[] args)
    {
        Guarda3<string> guardaString = new Guarda3<string>();
        guardaString.SetItem(0, "Hello");
        guardaString.SetItem(1, "World");
        guardaString.SetItem(2, "!");
        Console.WriteLine("Strings in guardaString:");
        foreach (var item in guardaString)
        {
            Console.WriteLine(item);
        }

        Guarda3<float> guardaFloat = new Guarda3<float>();
        guardaFloat.SetItem(0, 1.1f);
        guardaFloat.SetItem(1, 2.2f);
        guardaFloat.SetItem(2, 3.3f);
        Console.WriteLine("\nFloats in guardaFloat:");
        foreach (var item in guardaFloat)
        {
            Console.WriteLine(item);
        }

        try
        {
            guardaFloat.GetItem(3);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("\nIndex out of range exception caught.");
        }
    }
}
