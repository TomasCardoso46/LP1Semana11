using System;

class Program
{
    static void Main(string[] args)
    {
        // Teste com strings
        Guarda3<string> guardaString = new Guarda3<string>();
        guardaString.SetItem(0, "Hello");
        guardaString.SetItem(1, "World");
        guardaString.SetItem(2, "!");
        Console.WriteLine(guardaString.GetItem(0));
        Console.WriteLine(guardaString.GetItem(1));
        Console.WriteLine(guardaString.GetItem(2));

        Guarda3<float> guardaFloat = new Guarda3<float>();
        guardaFloat.SetItem(0, 1.1f);
        guardaFloat.SetItem(1, 2.2f);
        guardaFloat.SetItem(2, 3.3f);
        Console.WriteLine(guardaFloat.GetItem(0));
        Console.WriteLine(guardaFloat.GetItem(1));
        Console.WriteLine(guardaFloat.GetItem(2));
        guardaFloat.GetItem(3);
       
    }
}
