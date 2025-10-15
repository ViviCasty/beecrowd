
using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        string[] notas = Console.ReadLine().Split(' ');

        double n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
        double n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
        double n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
        double n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);

        double media = ((n1 * 2.0) + (n2 * 3.0) + (n3 * 4.0) + n4) / 10.0;
        double mediaTruncada = Math.Floor(media * 10) / 10.0;

        Console.WriteLine("Media: " + mediaTruncada.ToString("F1", CultureInfo.InvariantCulture));

        if (mediaTruncada >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (mediaTruncada < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));

            double mediaFinal = (mediaTruncada + notaExame) / 2.0;
            double mediaFinalTruncada = Math.Floor(mediaFinal * 10) / 10.0;

            if (mediaFinalTruncada >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine("Media final: " + mediaFinalTruncada.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
