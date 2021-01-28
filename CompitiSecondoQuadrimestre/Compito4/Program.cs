using System;

namespace Compito4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, somma = 0;
            int i = 0;
            do
            {
                Console.WriteLine("Inserisci il primo numero: ");
                a = int.Parse(Console.ReadLine());
            } while (a < 0);

            do
            {
                Console.WriteLine("Inserisci il secondo numero: ");
                b = int.Parse(Console.ReadLine());
            } while (b < 0);

            do
            {
                somma += a;
                i++;
            } while (i < b);

            Console.WriteLine("Il risultato è " + somma);
            Console.ReadKey();
        }
    }
}
