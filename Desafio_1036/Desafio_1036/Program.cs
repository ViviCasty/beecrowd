using System;

class URI
{

    static void Main(string[] args)
    {

        double[] valores = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        double A = valores[0], B = valores[1], C = valores[2];

        double delta = Math.Pow(B, 2) - 4 * A * C;

        double r1 = (-B + Math.Sqrt(delta)) / (2 * A);
        double r2 = (-B - Math.Sqrt(delta)) / (2 * A);

        


    }

}
