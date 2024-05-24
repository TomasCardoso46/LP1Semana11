using System;

class Program
{
    static void Main(string[] args)
    {
        
        Guarda3<string> guardaString = new Guarda3<string>();
        guardaString.SetItem(0, "Hello");
        guardaString.SetItem(1, "World");
        guardaString.SetItem(2, "!");
        Console.WriteLine("String item 0: " + guardaString.GetItem(0));
        Console.WriteLine("String item 1: " + guardaString.GetItem(1));
        Console.WriteLine("String item 2: " + guardaString.GetItem(2));

        
        Guarda3<float> guardaFloat = new Guarda3<float>();
        guardaFloat.SetItem(0, 1.1f);
        guardaFloat.SetItem(1, 2.2f);
        guardaFloat.SetItem(2, 3.3f);
        Console.WriteLine("Float item 0: " + guardaFloat.GetItem(0));
        Console.WriteLine("Float item 1: " + guardaFloat.GetItem(1));
        Console.WriteLine("Float item 2: " + guardaFloat.GetItem(2));

        
        try
        {
            guardaFloat.GetItem(3);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Index out of range exception caught.");
        }
    }
}
