namespace basicloop;

class Program
{
    static void Main(string[] args)
    {
        int[] nummers = { 1, 2, 3 };
        for (int i = 0; i< nummers.Length; i++)
        {
            Console.WriteLine($"nummers {i+1}: {nummers[i]}");
        }
    }
}
