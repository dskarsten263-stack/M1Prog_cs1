namespace bruto;

class Program
{
    static void Main(string[] args)
    {
        double[] brutoSalarissen = { 13450.80, 85698.90, 39598.23 };
        double[] nettoSalarissen = new double[3];

        nettoSalarissen[0] = brutoSalarissen[0] * (1 - 0.3582);
        Console.WriteLine($"persoon 1 houdt {nettoSalarissen[0]}netto over van {brutoSalarissen[0]} bruto");
              
    }
}
