using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        decimal[] notas = { 100.00m, 50.00m, 20.00m, 10.00m, 5.00m, 2.00m };
        decimal[] moedas = { 1.00m, 0.50m, 0.25m, 0.10m, 0.05m, 0.01m };

        Console.WriteLine("NOTAS:");
        foreach (decimal nota in notas)
        {
            int quantidade = (int)(valor / nota);
            Console.WriteLine($"{quantidade} nota(s) de R$ {nota:F2}");
            valor -= quantidade * nota;
        }

        Console.WriteLine("MOEDAS:");
        foreach (decimal moeda in moedas)
        {
            int quantidade = (int)(valor / moeda);
            Console.WriteLine($"{quantidade} moeda(s) de R$ {moeda:F2}");
            valor -= quantidade * moeda;
        }
    }
}

