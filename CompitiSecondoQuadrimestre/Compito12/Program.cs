using System;

namespace Compito12
{
    class Program
    {
        static void Main(string[] args)
        {
            int prodotti;
            Random random = new Random();
            int venditeTotali = 0;

            do
            {
                Console.WriteLine("Inserire il numero di prodotti: ");
                prodotti = int.Parse(Console.ReadLine());
            } while (prodotti <= 0);

            for (int i = 0; i < prodotti; i++)
            {
                int media = 0;
                for (int j = 0; j < 12; j++)
                {
                    Console.WriteLine("Inserisci le vendite del prodotto numero " + (i + 1) + " nel mese " + (j + 1));
                    int numero = random.Next(0, 100);
                    Console.WriteLine("È stato inserito il numero " + numero);
                    media += numero;
                }
                
                Console.WriteLine();

                Console.WriteLine("Le vendite complessive del prodotto " + i + " sono uguali a " + media);
                venditeTotali += media;
                media /= 12;
                Console.WriteLine("La media delle vendite del prodotto " + i + " è uguale a " + media + "\n");
            }

            Console.WriteLine();

            Console.WriteLine("Le vendite totali di tutti i prodotti sono uguali a " + venditeTotali);
            Console.ReadKey();
        }
    }
}
