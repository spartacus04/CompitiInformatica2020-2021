using System;

namespace Compito1
{
    class Program
    {
        static void Main(string[] args)
        {
            int casse = input("Inserisci il numero di casse");
            double media = 0;

            for (int i = 0; i < casse; i++)
            {
                int peso = input("Inserisci il peso della cassa numero " + (i + 1));
                int dist = input("Inserisci la distanza di spedizione della cassa numero " + (i + 1));

                int cost = costo(peso, dist);
                media += cost;

                Console.WriteLine("Il costo della cassa numero " + (i + 1) + " è uguale a " + cost + " euro\n");
            }

            media /= casse;

            Console.WriteLine("Il costo medio delle casse è " + Math.Round(media, 2) + " euro");
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

        static int costo(int peso, int dist){

            int costoDistanza;
            if(dist <= 50){
               costoDistanza = 5;
            }
            else if(dist > 50 && dist <= 100){
                costoDistanza = 10;
            }
            else if(dist > 100 && dist <= 300){
                costoDistanza = 14;
            }
            else{
                costoDistanza = 20;
            }
            
            return costoDistanza + (peso * 3);
        }
    }
}
