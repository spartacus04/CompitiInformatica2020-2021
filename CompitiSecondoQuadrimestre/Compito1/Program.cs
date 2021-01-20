using System;

namespace Compito1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Inserisci il numero di numeri: ");
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            double somma = 0, int i = 0;

            do
            {
                Console.WriteLine("Inserisci un numero: ");
                double num = double.Parse(Console.ReadLine());

                if(num > 0){
                    somma += num;
                }

                i++;
            } while (i < n);

            double media = somma / n;

            Console.WriteLine("La media è " + media);
            Console.ReadKey();

        }
    }
}
