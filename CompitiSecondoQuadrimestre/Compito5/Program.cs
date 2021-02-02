using System;

namespace Compito5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resto, quoziente = 0, somma = 0;

            do{

                do
                {
                    Console.WriteLine("Inserisci il primo numero: ");
                    a = int.Parse(Console.ReadLine());
                } while (a < 0);

                do
                {
                    Console.WriteLine("Inserisci il secondo numero: ");
                    b = int.Parse(Console.ReadLine());
                } while (b < 0);

            } while (a == b);

            if(a > b){
                do
                {
                    quoziente++;
                    somma += b;
                } while (somma <= (a - b));

                resto = a - somma;
            }
            else{
                do
                {
                    quoziente++;
                    somma += a;
                } while (somma <= (b - a));

                resto = b - somma;
            }

            Console.WriteLine("il quoziente è pari a " + quoziente);
            Console.WriteLine("il resto è pari a " + resto);
            Console.ReadKey();
        }
    }
}
