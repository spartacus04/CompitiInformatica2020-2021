using System;

namespace Compito1
{
    class Program
    {
        static void Main()
        {
            int esercizio = 0;
            do
            {
                Console.Clear();
                Console.Write("Inserisci il numero dell'esercizio(1 - 5) oppure 0 per uscire: ");
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

                case 4:
                    Esercizio4();
                    break;

                case 5:
                    Esercizio5();
                    break;
            }
        }

        /// <summary>
        /// Un rivenditore di auto deve determinare il prezzo da esporre su ciascuna auto quando viene portata
        /// nella sala mostra.Il prezzo dell'auto viene determinato rispettando le seguenti specifiche:
        /// a.il rivenditore inserisce il prezzo base
        /// b.al prezzo base viene sottratto il costo usura determinato seguendo la regola adottata dal
        /// quotidiano "Quattroruote": si sottrae 0,075€ per ogni chilometro riportato sul contachilometri
        /// dell'auto (Il rivenditore inserisce il numero di chilometri riportato sul contachilometri dell'auto)
        /// c.al prezzo ottenuto tramite i punti a) e b) si aggiunge il costo degli accessori di cui è, eventualmente,
        /// dotata l'auto. Tale costo è pari a 155€ per ogni accessorio (Il rivenditore inserisce il numero di
        /// accessori di cui è dotata l'auto)
        /// Infine al prezzo ottenuto tramite i punti a), b) e c) si applica uno sconto del 15%.
        /// Calcolare il costo finale dell'auto
        /// </summary>
        public static void Esercizio1()
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire il prezzo base: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserire i kilometri percorsi: ");
                float b = float.Parse(Console.ReadLine()); ;
                Console.Write("Inserire il numero di accessori: ");
                int c = Convert.ToInt32(Console.ReadLine());

                float CostoTotale = ((a - (b * 0.075f)) - (c * 155)) * 0.85f;

                Console.WriteLine($"\nIl costo totale è di euro: {Math.Round(CostoTotale, 2)}");
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
        /// Un gruppo di amici decide di fare un viaggio utilizzando l’aereo come mezzo di trasporto. Il prezzo
        /// del biglietto può cambiare da momento a momento.Le prime N persone ottengono un certo prezzo le
        /// rimanenti un altro.Quanto deve essere la quota per il individuale del viaggio in modo che risulti
        /// uguale per tutti i partecipanti.
        /// </summary>
        public static void Esercizio2()
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire il numero di persone: ");
                int p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserire il costo iniziale: ");
                float c1 = float.Parse(Console.ReadLine()); ;
                Console.Write("Inserire il costo successivo: ");
                float c2 = Convert.ToInt32(Console.ReadLine());

                Random random = new Random(DateTime.Now.Millisecond);

                int p1 = random.Next(1, p);
                int p2 = p - p1;

                float Costo = ((p1 * c1) + (p2 * c2)) / p;

                Console.WriteLine($"\nSupponendo che {p1} persone prendano il biglietto prima e {p2} persone dopo il costo sarà di euro: {Math.Round(Costo, 2)}");
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
        /// Tre persone eseguono un lavoro. Ognuna di esse è impiegata per un certo numero, anche differente,
        /// di ore.Conoscendo il compenso complessivo per il lavoro dividerlo in modo proporzionale (in base al
        /// n. di ore) fra i tre lavoratori.
        /// </summary>
        public static void Esercizio3()
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire il numero di ore del primo lavoratore: ");
                int o1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserire il numero di ore del secondo lavoratore: ");
                int o2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserire il numero di ore del terzo lavoratore: ");
                int o3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserire il compenso totale: ");
                float C = Convert.ToInt32(Console.ReadLine());

                int OreTotali = o1 + o2 + o3;
                float PrezzoOrario = C / OreTotali;

                Console.WriteLine($"\nIl lavoratore numero 1 guadagnerà euro: {Math.Round(PrezzoOrario * o1, 2)}");
                Console.WriteLine($"Il lavoratore numero 2 guadagnerà euro: {Math.Round(PrezzoOrario * o2, 2)}");
                Console.WriteLine($"Il lavoratore numero 3 guadagnerà euro: {Math.Round(PrezzoOrario * o3, 2)}");
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
        /// Si spediscono N casse di merce e ogni cassa pesa C kg. il trasporto costa 5 € al kg, più una spesa
        /// fissa di 10 €. Calcolare la spesa complessiva per il trasporto.
        /// </summary>
        public static void Esercizio4()
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire il numero di casse: ");
                int nc = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserire il peso di una cassa: ");
                int pc = Convert.ToInt32(Console.ReadLine());

                int PrezzoCasse = (nc * pc * 5) + 10;

                Console.WriteLine($"\nLa spesa complessiva sarà di euro: {PrezzoCasse}");
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
        /// Il costo unitario delle fotocopie in bianco e nero è di 10 centesimi di euro, quello delle fotocopie a
        /// colori è di 80 centesimi di euro, mentre il costo per rilegare un fascicolo di fotocopie è di € 1.30.
        /// Conoscendo il numero di fotocopie in bianco e nero e il numero di fotocopie a colori, calcola e
        /// visualizza: il numero di fotocopie totali acquistate e il costo totale del fascicolo di fotocopie rilegato.
        /// </summary>
        public static void Esercizio5()
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire il numero di fotocopie in bianco e nero: ");
                int f1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserire il numero di fotocopie a colori: ");
                int f2 = Convert.ToInt32(Console.ReadLine());

                const float p1 = 0.10f;
                const float p2 = 0.80f;

                int NumeroFotocopie = f1 + f2;
                float CostoTotale = (f1 * p1) + (f2 * p2) + 1.3f;

                Console.WriteLine($"\nIl costo totale di {NumeroFotocopie} sarà di euro: {Math.Round(CostoTotale, 2)}");
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
