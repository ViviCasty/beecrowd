using System;

class URI
{

    static void Main(string[] args)
    {

        int idade = int.Parse(Console.ReadLine());



        int anos = idade / 365;

        int restoAnos = idade % 365;

        int meses = restoAnos / 30;

        int dias = restoAnos % 30;

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");


    }

}
