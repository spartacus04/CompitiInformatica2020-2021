using System;

namespace Compito7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire i posti per veicolo: ");
                int posti = int.Parse(Console.ReadLine());
                Console.Write("Inserire le persone totali: ");
                int persone = int.Parse(Console.ReadLine());
                Console.Write("Inserire i kilometri percorsi: ");
                double km = double.Parse(Console.ReadLine());
                Console.Write("Inserire costo per litro di benzina: ");
                double costo = double.Parse(Console.ReadLine());
                Console.Write("Inserire il consumo di benzina al kilometro: ");
                double consumo = double.Parse(Console.ReadLine());

                int veicoli = (int)Math.Floor((float)persone / (float)posti);
                int postiliberi = (posti * veicoli) - persone;

                double costobenzina = (km * consumo * costo * veicoli) / (persone - veicoli);

                double quota = 0;

                if (persone < 20)
                {
                    quota = 8;
                }
                else if (persone < 50)
                {
                    quota = 5;
                }
                else if (persone < 100)
                {
                    quota = 4;
                }
                else if (veicoli >= 10)
                {
                    quota = 2;
                }

                double costototale = costobenzina + quota;
                Console.WriteLine($"\nIl costo a persona è di {Math.Round(costototale, 2)} euro");
                Console.WriteLine($"I posti liberi rimasti sono {postiliberi}");
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
