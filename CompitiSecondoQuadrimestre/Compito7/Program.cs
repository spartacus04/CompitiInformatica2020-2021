using System;

namespace Compito7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int somma = 0;

            do
            {
                Console.WriteLine("Inserisci un numero: ");
                int a = int.Parse(Console.ReadLine());

                somma += a;
                if(a % 2 == 0)
                    i++;
            } while (i < 5);

            Console.WriteLine("La somma è uguale a " + somma);
            Console.ReadKey();
        }
    }
}