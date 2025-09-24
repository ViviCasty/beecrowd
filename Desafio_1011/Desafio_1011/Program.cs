using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = (4.0 / 3) * 3.14159 * Math.Pow(raio, 3);

        Console.WriteLine("VOLUME = " + resultado.ToString("F3", CultureInfo.InvariantCulture));

    }

}
