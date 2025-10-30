namespace funccall;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("....X....");
            Console.SetCursorPosition(4, 0);
            Console.Write('?');

            Console.SetCursorPosition(0, 1);
            Console.Write("deze regel is normaal ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("deze tekst is groen");
            Console.ResetColor();
        }
    }