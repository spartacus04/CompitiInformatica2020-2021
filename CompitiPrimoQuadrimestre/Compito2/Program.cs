using System;

namespace Compito2
{
    class Program
    {
        static void Main()
        {
            int esercizio = 0;
            do
            {
                Console.Clear();
                Console.Write("Inserisci il numero dell'esercizio(1 - 2) oppure 0 per uscire: ");
            } while (!int.TryParse(Console.ReadLine(), out esercizio));

            switch (esercizio)
            {
                default:
                    Main();
                    break;

                case 0:
                    Environment.Exit(0);
                    break;

                case 1:
                    Esercizio1();
                    break;

                case 2:
                    Esercizio2();
                    break;
            }
        }

        /// <summary>
        /// Un negozio effettua lo sconto del 10% se il totale speso è inferiore o uguale a 500
        /// euro e del 20% se invece è superiore. Scrivi un programma che inserendo il totale
        /// speso ne calcola lo sconto e visualizza sullo schermo sia lo sconto sia l’importo da
        /// pagare.
        /// </summary>
        public static void Esercizio1()
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire il prezzo: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nIl prezzo scontato è di euro: {(a <= 500 ? a - (a / 100 * 10) :  a - (a / 100 * 20))}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore:\n\n" + e);
            }
            finally
            {
                Console.WriteLine("\nPremere un tasto per continuare");
                Console.ReadKey();
                Main();
            }
        }

        /// <summary>
        /// Leggi un numero e scrivilo a video solo se tale numero è divisibile per 5.
        /// </summary>
        public static void Esercizio2()
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire il numero: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(a % 5 == 0 ? "Il numero è divisibile per 5" : "Il numero non è divisibile per 5");
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore:\n\n" + e);
            }
            finally
            {
                Console.WriteLine("\nPremere un tasto per continuare");
                Console.ReadKey();
                Main();
            }
        }
    }
}
