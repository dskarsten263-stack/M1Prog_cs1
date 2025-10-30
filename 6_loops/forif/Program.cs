namespace forif;

class Program
{
    static void Main(string[] args)
    {
        int[] nummers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 3; i < nummers.Length - 2; i++)
        {
            Console.WriteLine(nummers[i]);
        }
    }
}
