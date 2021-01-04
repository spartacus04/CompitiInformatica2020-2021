using System;

namespace Compito4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Inserisci la media dello studente: ");
                double m = double.Parse(Console.ReadLine());
                Console.Write("Inserisci il reddito studente: ");
                double r = double.Parse(Console.ReadLine());
                double t = 18;

                if (m <= 8)
                {
                    if (m < 7)
                    {
                        t += 25;
                    }
                    else
                    {
                        t += 17.5;
                    }
                }

                if (r < 1600)
                {
                    t -= (t * 0.4);
                }
                Console.WriteLine($"L'importo dell'iscrizione è di euro: {t}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore:\n\n" + e);
            }
            finally
            {
                Console.WriteLine("\nPremere un tasto per continuare");
                Console.ReadKey();
            }
        }
    }
}
