using System;

class URI
{

    static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(' ');
        int A = int.Parse(entrada[0]);
        int B = int.Parse(entrada[1]);
        int C = int.Parse(entrada[2]);
        int D = int.Parse(entrada[3]);

        if (B > C && D > A && (C + D) > (A+B) && C> 0 && D > 0 && A %2 ==0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }


    }

}
