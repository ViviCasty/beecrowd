using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] p1 = Console.ReadLine().Split(' ');
        string[] p2 = Console.ReadLine().Split(' ');

        double[] ponto1 = new double[2];
        double[] ponto2 = new double[2];


        for (int i = 0; i < 2; i++)
        {
            ponto1[i] = ToDouble(p1[i]);
            ponto2[i] = ToDouble(p2[i]);
        }

        double distancia = Math.Sqrt(Math.Pow(ponto2[0] - ponto1[0], 2) + Math.Pow(ponto2[1] - ponto1[1], 2));

        Console.WriteLine(distancia.ToString("f4", CultureInfo.InvariantCulture));




    }

    static double ToDouble(string valor)
    {
        return double.Parse(valor, CultureInfo.InvariantCulture);
    }

}
