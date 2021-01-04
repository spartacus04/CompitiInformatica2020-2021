using System;

namespace Compito3
{
    class Program
    {
        /// <summary>
        /// Inserire le coordinate di un punto del piano (x,y) e comunicare il numero del quadrante di appartenenza
        /// Riferimento quadranti https://drive.google.com/file/d/1WamrdR17zbcdXl6LIslE4jL06hnGgqMm/view
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Inserisci il valore della coordinata X: ");
                float x = float.Parse(Console.ReadLine());
                Console.Write("Inserisci il valore della coordinata Y: ");
                float y = float.Parse(Console.ReadLine());
                Console.Write("\n");

                if (x > 0)
                {
                    if (y > 0)
                    {
                        Console.WriteLine("La coordinata specificata fa parte del quadrante numero 1");
                    }
                    else if (y < 0)
                    {
                        Console.WriteLine("La coordinata specificata fa parte del quadrante numero 4");
                    }
                    else
                    {
                        Console.WriteLine("La coordinata specificata non fa parte di nessun quadrante");
                    }
                }
                else if (x < 0)
                {
                    if (y > 0)
                    {
                        Console.WriteLine("La coordinata specificata fa parte del quadrante numero 2");
                    }
                    else if (x < 0)
                    {
                        Console.WriteLine("La coordinata specificata fa parte del quadrante numero 3");
                    }
                    else
                    {
                        Console.WriteLine("La coordinata specificata non fa parte di nessun quadrante");
                    }
                }
                else
                {
                    Console.WriteLine("La coordinata specificata non fa parte di nessun quadrante");
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
