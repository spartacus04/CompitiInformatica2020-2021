using System;

namespace Compito8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuole visualizzare l'esercizio normale (1) oppure la variante (2)?");
            char variante = char.Parse(Console.ReadLine());

            if(variante == '1'){
                Console.WriteLine("Inserisci il saldo iniziale: ");
                double saldo = double.Parse(Console.ReadLine());

                Console.WriteLine("Inserisci il numero di movimenti: ");
                int movimenti = int.Parse(Console.ReadLine());

                for (int i = 0; i < movimenti; i++)
                {
                    Console.WriteLine("Il movimento è un prelievo o un versamento? (Prelievo/Versamento)");
                    char scelta = char.Parse(Console.ReadLine());

                    if(scelta == 'P' || scelta == 'p'){
                        Console.WriteLine("Inserisci il numero di soldi prelevati: ");
                        double soldi = double.Parse(Console.ReadLine());

                        saldo -= soldi;
                    }
                    else if(scelta == 'V' || scelta == 'v'){
                        Console.WriteLine("Inserisci il numero di soldi versati: ");
                        double soldi = double.Parse(Console.ReadLine());

                        saldo += soldi;
                    }
                    else{
                        Console.WriteLine("Valore sbagliato");
                    }
                }

                Console.WriteLine("Il saldo finale è " + saldo);
            }
            else if(variante == '2'){
                Console.WriteLine("Inserisci il saldo iniziale: ");
                double saldo = double.Parse(Console.ReadLine());
                double soldi = 0;

                do
                {
                    Console.WriteLine("Il movimento è un prelievo o un versamento? (Prelievo/Versamento)");
                    char scelta = char.Parse(Console.ReadLine());

                    if(scelta == 'P' || scelta == 'p'){
                        Console.WriteLine("Inserisci il numero di soldi prelevati (0 per fare il totale): ");
                        soldi = double.Parse(Console.ReadLine());

                        saldo -= soldi;
                    }
                    else if(scelta == 'V' || scelta == 'v'){
                        Console.WriteLine("Inserisci il numero di soldi versati (0 per fare il totale): ");
                        soldi = double.Parse(Console.ReadLine());

                        saldo += soldi;
                    }
                    else{
                        Console.WriteLine("Valore sbagliato");
                    }
                } while (soldi != 0);

                Console.WriteLine("Il saldo finale è " + saldo);
            }
            
            Console.ReadKey();

        }
    }
}
