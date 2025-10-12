using System.Collections.Generic;
using System.Globalization;

using System; 

class URI
{

    static void Main(string[] args)
    {

        Dictionary<int, double> ValorItem = new Dictionary<int, double>();

        ValorItem.Add(1, 4.00); 
        ValorItem.Add(2, 4.50);
        ValorItem.Add(3, 5.00);
        ValorItem.Add(4, 2.00);
        ValorItem.Add(5, 1.50);

        string[] valores = Console.ReadLine().Split(' ');

        int codigo = int.Parse(valores[0]);
        double quantidade = double.Parse(valores[1]);

        if (ValorItem.ContainsKey(codigo))
        {
            double total = ValorItem[codigo] * quantidade;
            Console.WriteLine($"Total: R$ {total.ToString("f2", CultureInfo.InvariantCulture)}");
        }

    }

}
