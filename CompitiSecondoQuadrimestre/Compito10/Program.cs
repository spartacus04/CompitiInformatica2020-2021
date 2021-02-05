using System;

namespace Compito10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, j = 1, somma = 0;
            do
            {
                Console.WriteLine("Inserisci un numero: ");
                a = int.Parse(Console.ReadLine());
            } while (a <= 0);

            for (int i = 0; i < a; i++)
            {
                somma += j;
                j += 2;
            }

            j = 1;
            somma = 0;
            int ii = 0;
            do
            {
                somma += j;
                j += 2;
                ii++;
            } while (ii < a);

            Console.WriteLine("Il quadrato di " + a + " è " + somma);
        }
    }
}
