namespace math;

class Program
{
    static void Main(string[] args)
    {
       double kleiner = 9;
        double groter = 19;
        double welkeIsKleiner = Math.Min(kleiner, kleiner);
        Console.WriteLine($"{welkeIsKleiner:0.##} is kleinste van {kleiner:0.##} en {groter:0.##}");

        double Groter = 14;
        double Kleiner = 9;
        double WelkeIsGroter = Math.Min(Groter, Groter);
        Console.WriteLine($"{WelkeIsGroter:0.##} is Grootste van {Kleiner:0.##} en {Groter:0.##}");

        double value = 16;
        double clamped = Math.Clamp(value, 20, 30);
        double sqrt = Math.Sqrt(value);
        Console.WriteLine($"het clamp resultaat van {value} met min 20 en max 30 is de {clamped} de Sqrt van {value} is de {sqrt:0}");
    }
}
