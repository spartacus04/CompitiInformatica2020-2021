using System;

namespace Compito6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int i = 0, j = 1;
            char s;

            do
            {
                int somma = 0;
                Console.WriteLine("Inserisci il primo numero: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero: ");
                b = int.Parse(Console.ReadLine());

                do
                {
                    somma += a;
                    i++;
                } while (i < b);

                Console.WriteLine("Il prodotto della coppia " + j + " è uguale a " + somma);

                Console.WriteLine("Vuoi inserire altri numeri? (Si/No)");

                s = char.Parse(Console.ReadLine());
                j++;
            } while (s == 's' || s == 'S');
        }
    }
}