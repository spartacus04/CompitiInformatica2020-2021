using System;

namespace Compito2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lav = input("Inserisci il numero di lavoratori");
            double trattenuteTotali = 0;

            for (int i = 0; i < lav; i++)
            {
                int cost = input("Inserisci il costo di un ora di lavoro del lavoratore numero " + (i + 1));
                int ore = input("Inserisci il numero di ore di lavoro del lavoratore numero " + (i + 1));

                double costoTotale = cost * ore;
                double trattenuta = Math.Round(trattenute(costoTotale));
                trattenuteTotali += trattenuta;
                costoTotale -= trattenuta;

                Console.WriteLine("Il lavoratore numero " + (i + 1) + " verrà pagato " + costoTotale + " euro\n");
            }

            Console.WriteLine("Le trattenute totali sono di " + trattenuteTotali + " euro");
            Console.ReadKey();
        }

        static int input(string messaggio){
            int a;
            do
            {
                Console.WriteLine(messaggio);
                a = int.Parse(Console.ReadLine());
            } while (a <= 0);
            return a;
        }

        static double trattenute(double costoTotale){
            return (costoTotale / 100) * 27;
        }
        
    }
}
