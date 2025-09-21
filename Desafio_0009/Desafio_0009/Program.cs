using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string Nome = Console.ReadLine();
        double SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double total = SalarioFixo + (vendas * 0.15);

        Console.WriteLine("TOTAL = R$ " + total.ToString("f2", CultureInfo.InvariantCulture));

    }

}
