namespace output;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int a = 1;
        double b = 1.9;
        float vx = 9.87f;
        bool ja = true;

        Console.WriteLine($"mijn int met de naam a heeft als waarde {a}");
        Console.WriteLine($"mijn double met de naam b heeft als waarde {b}");
        Console.WriteLine($"mijn float met de naam vx heeft als waarde {vx}");
        Console.WriteLine($"mijn bool met de naam ja heeft als waarde {ja}");
    }
}