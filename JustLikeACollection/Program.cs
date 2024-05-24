using System;

namespace JustLikeACollection
{


class Program
{
    static void Main(string[] args)
    {
        
        Guarda3<string> guardaString = new Guarda3<string> { "Hello", "World", "!" };
        Console.WriteLine("Strings in guardaString:");
        foreach (var item in guardaString)
        {
            Console.WriteLine(item);
        }

        
        Guarda3<float> guardaFloat = new Guarda3<float> { 1.1f, 2.2f, 3.3f };
        Console.WriteLine("\nFloats in guardaFloat:");
        foreach (var item in guardaFloat)
        {
            Console.WriteLine(item);
        }

        
        try
        {
            guardaFloat.Add(4.4f);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("\nCannot add more items: " + e.Message);
        }
    }
}

}
