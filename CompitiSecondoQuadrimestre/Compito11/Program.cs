using System;

namespace Compito11
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.WriteLine("Inserisci il numero di film: ");
                N = int.Parse(Console.ReadLine());
            } while (N <=0);

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Inserisci il titolo del film: ");
                string titolo = Console.ReadLine();
                
                int somma = 0;

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("Inserisci il numero di spettatori nel giorno " + j);
                    int spettatori = int.Parse(Console.ReadLine());

                    somma += spettatori;    //somma = somma + spettatori
                }

                double media = somma / 10;
                Console.WriteLine("Il film " + titolo + " ha avuto " + media + " visualizzazioni medie");
            }
            Console.ReadKey();
        }
    }
}