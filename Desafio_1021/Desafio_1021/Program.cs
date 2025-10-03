using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double nota100 = valor / 100.00;
        int parteInteira100 = (int)nota100;

        double resto100 = valor % 100;

        double nota50 = resto100 / 50.00;

        int parteInteira50 = (int)nota50;

        double resto50 = resto100 % 50;

        double nota20 = resto50 / 20.00;

        int parteInteira20 = (int)nota20;

        double resto20 = resto50 % 20;

        double nota10 = resto20 / 10.00;

        int parteInteira10 = (int)nota10;

        double resto10 = resto20 % 10;

        double nota5 = resto10 / 5.00;

        int parteInteira5 = (int)nota5;

        double resto5 = resto10 % 5;

        double nota2 = resto5 / 2.00;

        int parteInteira2 = (int)nota2;

        double resto2 = resto5 % 2;



        Console.WriteLine("NOTAS:");
        Console.WriteLine(parteInteira100 + " nota(s) de R$ 100,00");
        Console.WriteLine(parteInteira50 + " nota(s) de R$ 50,00");
        Console.WriteLine(parteInteira20 + " nota(s) de R$ 20,00");
        Console.WriteLine(parteInteira10 + " nota(s) de R$ 10,00");
        Console.WriteLine(parteInteira5 + " nota(s) de R$ 5,00");
        Console.WriteLine(parteInteira2 + " nota(s) de R$ 2,00");

        double moeda1 = resto2 / 1.00;
        int parteInteiraMoeda1 = (int)moeda1;
        double restomoeda1 = moeda1 % 1.00;

        double moedaCinquenta = restomoeda1 / 0.50;
        int parteInteiraMoedaCinquenta = (int)moedaCinquenta;
        double restoMoedaCinquenta = moedaCinquenta % 0.50;

        double moeda25 = restoMoedaCinquenta / 0.25;
        int partemoeda25 = (int)moeda25;
        double restomoeda25 = moeda25 % 0.25;


        double moeda10 = restomoeda25 / 0.10;
        int partemoeda10 = (int)moeda10;
        double restomoeda10 = moeda10 % 0.10;


        double moeda05 = restomoeda10 / 0.05;
        int partemoeda05 = (int)moeda05;
        double restomoeda05 = moeda05 % 0.05;


        double moeda01 = restomoeda05 / 0.01;
        int partemoeda01 = (int)moeda01;

        Console.WriteLine("MOEDAS:");
        Console.WriteLine(parteInteiraMoeda1 + " moeda(s) de R$ 1,00");
        Console.WriteLine(parteInteiraMoedaCinquenta + " moeda(s) de R$ 0,50");
        Console.WriteLine(partemoeda25 + " moeda(s) de R$ 0,25");
        Console.WriteLine(partemoeda10 + " moeda(s) de R$ 0,10");
        Console.WriteLine(partemoeda05 + " moeda(s) de R$ 0,05");
        Console.WriteLine(partemoeda01 + " moeda(s) de R$ 0,01");










    }

}
