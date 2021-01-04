using System;

namespace Compito3
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
        {
            Console.WriteLine("Data l'equazione ax + b = 0");

            Console.WriteLine("Inserisci il valore di a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il valore di b");
            int b = int.Parse(Console.ReadLine());

            //ax = -b
            //x = -b : a

            int x = (0 - b) / a;

            Console.WriteLine("Il valore di x è " + x);
            Console.ReadKey();
        }
        }
    }
}
