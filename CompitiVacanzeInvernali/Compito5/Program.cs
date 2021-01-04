using System;

namespace Compito5
{
    class Program
    {
        static void Main(string[] args)
        {
            int piano, giorni, PrezzoAlGiorno; 
    
            Console.WriteLine("Inserire il numero del piano: ");
            piano = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il numero dei giorni: ");
            giorni = int.Parse(Console.ReadLine());

            switch (piano)
            {
                case 1:
                    PrezzoAlGiorno = 65;
                    break;
                case 2:
                    PrezzoAlGiorno = 75;
                    break;
                case 3:
                    PrezzoAlGiorno = 80;
                    break;
                case 4:
                    PrezzoAlGiorno = 85;
                    break;
                default:
                    PrezzoAlGiorno = 0;
                    break;
            }

            int PrezzoTotale = PrezzoAlGiorno * giorni;

            Console.WriteLine("Il prezzo totale è " + PrezzoTotale);
            Console.ReadKey();
        }
    }
}
