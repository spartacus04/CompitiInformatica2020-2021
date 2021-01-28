using System;

namespace Compito5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resto, quoziente;

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
                quoziente = a / b;
                resto = a % b;
            }
            else{
                quoziente = b / a;
                resto = b % a;
            }

            Console.WriteLine("il quoziente è pari a " + quoziente);
            Console.WriteLine("il resto è pari a " + resto);
            Console.ReadKey();
        }
    }
}
