using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = ((a * 2) + (b * 3) + (c * 5)) / 10;

        Console.WriteLine("MEDIA = " + resultado.ToString("F1", CultureInfo.InvariantCulture));

    }

}