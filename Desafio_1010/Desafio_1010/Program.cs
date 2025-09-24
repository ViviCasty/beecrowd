using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string linha1 = Console.ReadLine();
        string linha2 = Console.ReadLine();

        string[] pts1 = linha1.Split(' ');
        string[] pts2 = linha2.Split(' ');

        double qtd1 = double.Parse(pts1[1], CultureInfo.InvariantCulture);
        double valor1 = double.Parse(pts1[2], CultureInfo.InvariantCulture);

        double resultado1  = qtd1 * valor1;

        double qtd2 = double.Parse(pts2[1], CultureInfo.InvariantCulture);
        double valor2 = double.Parse(pts2[2], CultureInfo.InvariantCulture);
        double resultado2 = qtd2 * valor2;

        double resultadoFinal = resultado1 + resultado2;

        Console.WriteLine("VALOR A PAGAR: R$ " + resultadoFinal.ToString("F2", CultureInfo.InvariantCulture));





    }

}
