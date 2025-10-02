using System;

class URI
{

    static void Main(string[] args)
    {

        //int segundos = int.Parse(Console.ReadLine());

        //TimeSpan ts = TimeSpan.FromSeconds(segundos);

        //int horas = ts.Hours;
        //int minutos = ts.Minutes;
        //int segs = ts.Seconds;

        //Console.WriteLine($"{horas}:{minutos}:{segs}");


        int segundos = int.Parse(Console.ReadLine());

        int horas = segundos / 3600;

        int restoHoras = segundos % 3600;

        int minutos = restoHoras / 60;

        int segs = restoHoras % 60;

        Console.WriteLine($"{horas}:{minutos}:{segs}");



    }

}
