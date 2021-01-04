using System;

namespace Compito1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Kg;
            double CostoBiglietto;

            Console.WriteLine("Inserisci il peso del bagaglio: ");
            Kg = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il costo del biglietto: ");
            CostoBiglietto = double.Parse(Console.ReadLine());

            if(Kg > 20) {
                double percentuale = CostoBiglietto * 0.02;
                int PesoAggiuntivo = Kg - 20;

                double CostoAggiuntivo = percentuale * PesoAggiuntivo;
                double CostoTotale = CostoBiglietto + CostoAggiuntivo;

                Console.WriteLine("Il costo totale è " + CostoTotale);
            }
            else{
                Console.WriteLine("Il costo totale è " + CostoBiglietto);
            }
            Console.ReadKey();
        }
    }
}
