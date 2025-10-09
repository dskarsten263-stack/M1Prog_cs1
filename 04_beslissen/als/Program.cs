namespace als;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        bool sleutelkwijt = true; // true means you lost your key

        if (sleutelkwijt)
        {
            Console.WriteLine("je zoekt je sleutel");
            Console.WriteLine("heb je je sleutel gevonden? (ja/nee)");
            bool sleutelkwijt = Console.ReadLine() == "nee";
            Console.WriteLine("de deur blijft opsloten");
        }
        else
        {
            Console.WriteLine("je hebt je sleutel");
            Console.WriteLine("je doet de deur open");
            Console.WriteLine("de deur gaat open en je kan naar binnen");
        }
    }
}
