using System;

class URI
{

    static void Main(string[] args)
    {

        int valor = int.Parse(Console.ReadLine());

        double nota100 = valor / 100.00;
        int parteInteira100 = (int)nota100;

        int resto100 = valor % 100;

        double nota50 = resto100 / 50.00;

        int parteInteira50 = (int)nota50;

        int resto50 = resto100 % 50;

        double nota20 = resto50 / 20.00;

        int parteInteira20 = (int)nota20;

        int resto20 = resto50 % 20;

        double nota10 = resto20 / 10.00;

        int parteInteira10 = (int)nota10;
        
        int resto10 = resto20 % 10;

        double nota5 = resto10 / 5.00;

        int parteInteira5 = (int)nota5;

        int resto5 = resto10 % 5;

        double nota2 = resto5 / 2.00;

        int parteInteira2 = (int)nota2;

        int resto2 = resto5 % 2;

        double nota1 = resto2 / 1.00;

        int parteInteira1 = (int)nota1;

        Console.WriteLine(valor);
        Console.WriteLine(parteInteira100 + " nota(s) de R$ 100,00");
        Console.WriteLine(parteInteira50 + " nota(s) de R$ 50,00");
        Console.WriteLine(parteInteira20 + " nota(s) de R$ 20,00");
        Console.WriteLine(parteInteira10 + " nota(s) de R$ 10,00");
        Console.WriteLine(parteInteira5 + " nota(s) de R$ 5,00");
        Console.WriteLine(parteInteira2 + " nota(s) de R$ 2,00");
        Console.WriteLine(parteInteira1 + " nota(s) de R$ 1,00");
    }

}