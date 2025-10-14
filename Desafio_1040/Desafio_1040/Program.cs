using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[]  notas = Console.ReadLine().Split(' ');

        double n1 = Convert.ToDouble(notas[0], CultureInfo.InvariantCulture);
        double n2 = Convert.ToDouble(notas[1], CultureInfo.InvariantCulture);
        double n3 = Convert.ToDouble(notas[2], CultureInfo.InvariantCulture);
        double n4 = Convert.ToDouble(notas[3], CultureInfo.InvariantCulture);

        double media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10;


        if (media >= 7.0)
        {
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno reprovado.");
        }
        else if (media >= 5.0 && media <= 6.9)
        {
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno em exame.");
            double notaExame = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
            double mediaFinal = (media + notaExame) / 2;
            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }


    }

}
