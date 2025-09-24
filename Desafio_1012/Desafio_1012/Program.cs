using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double[] valores = Console.ReadLine().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();

        double A = valores[0];
        double B = valores[1];
        double C = valores[2];

        double triangulo = (A * C) / 2;
        double circulo = 3.14159 * Math.Pow(C, 2);
        double trapezio = ((A + B) * C) / 2;
        double quadrado = B * B;
        double retangulo = A * B;

        Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {quadrado.ToString("F3",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");




    }

}
