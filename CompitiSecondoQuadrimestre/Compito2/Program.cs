using System;

namespace Compito2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Inserisci il numero di terne di numeri: ");
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            int i = 0;

            do
            {
                int j = 0;
                double somma = 0;

                do
                {
                    Console.WriteLine("Inserisci un numero: ");
                    double num = double.Parse(Console.ReadLine());

                    somma += num;
                    j++;
                } while (j < 3);

                double media = somma / 3;
                Console.WriteLine("La media è " + media);

                i++;
            } while (i < n);

            Console.ReadKey();
        }
    }
}
