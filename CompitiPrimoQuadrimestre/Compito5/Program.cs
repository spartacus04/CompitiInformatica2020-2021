using System;

namespace Compito5
{
    class Program
    {
        static void Main()
        {
            int esercizio = 0;
            do
            {
                Console.Clear();
                Console.Write("Inserisci il numero dell'esercizio(1 - 3) oppure 0 per uscire: ");
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

                case 3:
                    Esercizio3();
                    break;
            }
        }

        /// <summary>
        /// Ingresso al Museo. Calcolare il costo per l’ingresso ad un museo sapendo che applica le seguenti tariffe:
        ///  10€ fino a 1 persona
        ///  8€ da 2 a 15 persone
        ///  6€ per più di 15 persone(una gratuità ogni 20 persone)
        /// Calcolare il costo complessivo e il costo a persona in base alle precedenti condizioni.
        /// </summary>
        public static void Esercizio1()
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire il numero di persone: ");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Console.WriteLine("\nIl costo totale e a persona sarà di 10 euro");
                }
                else if (a > 2 && 15 < a)
                {
                    Console.WriteLine($"\nIl costo totale è di {8 * a} euro mentre il costo a persona sarà di 8 euro");
                }
                else if (a > 15)
                {
                    int b = a / 20;
                    Console.WriteLine($"\nIl costo totale è di {8 * (a - b)} euro mentre il costo a persona sarà di{(8 * (a - b)) / a} euro");
                }
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
        /// Il biglietto di ingresso ad un museo ha le seguenti tariffe:
        /// 1. bambini di età <6 anni gratuito
        /// 2. studenti 8€
        /// 3. pensionati 10€
        /// 4. altro 15€
        /// Creare un programma in cui l&#39;utente inserisce la scelta (1-4) e viene comunicato il prezzo corrispondente. Se il
        /// numero non è una opzione valida viene mostrato un messaggio di errore
        /// </summary>
        public static void Esercizio2()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("1. bambini di età <6 anni");
                Console.WriteLine("2. studenti");
                Console.WriteLine("3. pensionati");
                Console.WriteLine("4. altro");
                Console.Write("Inserire la tariffa: ");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine($"Il prezzo è gratuito");
                        break;

                    case 2:
                        Console.WriteLine($"Il prezzo è di 8 euro");
                        break;

                    case 3:
                        Console.WriteLine($"Il prezzo è di 10 euro");
                        break;

                    case 4:
                        Console.WriteLine($"Il prezzo è di 15 euro");
                        break;

                    default:
                        throw new Exception("La tariffa specificata non esiste");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErrore:\n\n" + e);
            }
            finally
            {
                Console.WriteLine("\nPremere un tasto per continuare");
                Console.ReadKey();
                Main();
            }
        }

        /// <summary>
        /// il costo del biglietto di un museo è di 15€ ma ci sono le seguenti promozioni:
        ///  eta<10 -70%
        ///  eta<18 -50%
        ///  eta>65 -30%
        /// Inserita l'età del visitatore, visualizzare importo del biglietto
        /// </summary>
        public static void Esercizio3()
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire l'età");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a < 10)
                {
                    Console.WriteLine($"\nIl costo del biglietto è di {Math.Round(15 - (15 * 0.7), 2)} euro");
                }
                else if (a < 18)
                {
                    Console.WriteLine($"\nIl costo del biglietto è di {Math.Round(15 - (15 * 0.5), 2)} euro");
                }
                else if (a > 65)
                {
                    Console.WriteLine($"\nIl costo del biglietto è di {Math.Round(15 - (15 * 0.3), 2)} euro");
                }
                else
                {
                    Console.WriteLine("\nIl costo del biglietto è di 15 euro");
                }
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
