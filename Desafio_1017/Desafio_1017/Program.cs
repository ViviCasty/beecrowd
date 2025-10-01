using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int tempo =  int.Parse(Console.ReadLine());

        int velocidade = int.Parse(Console.ReadLine());

        double litros = (tempo * velocidade) / 12.0;

        Console.WriteLine(litros.ToString("f3", CultureInfo.InvariantCulture));

    }

}
