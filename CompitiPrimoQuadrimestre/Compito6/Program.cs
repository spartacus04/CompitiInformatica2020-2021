using System;

namespace Compito6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Inserire un giorno: ");
                int giorno = int.Parse(Console.ReadLine());
                Console.Write("Inserire un mese: ");
                int mese = int.Parse(Console.ReadLine());

                //DateTime date = new DateTime(DateTime.Now.Year, mese, giorno);
                //Console.WriteLine($"Il giorno della settimana è {date.DayOfWeek} ");

                int num = (mese - 1) * 30 + giorno;
                int resto = num % 7;

                Console.Write("Il giorno è ");
                switch (resto)
                {
                    case 1:
                        Console.WriteLine("lunedì");
                        break;

                    case 2:
                        Console.WriteLine("martedì");
                        break;

                    case 3:
                        Console.WriteLine("mercoledì");
                        break;

                    case 4:
                        Console.WriteLine("giovedì");
                        break;

                    case 5:
                        Console.WriteLine("venerdì");
                        break;

                    case 6:
                        Console.WriteLine("sabato");
                        break;

                    case 7:
                        Console.WriteLine("domenica");
                        break;
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
            }
        }
    }
}
