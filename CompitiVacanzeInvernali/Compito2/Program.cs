using System;

namespace Compito2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, m, temperatura;
            Console.WriteLine("Inserisci la temperatura della stanza 1:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci la temperatura della stanza 2:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci la temperatura della stanza 3:");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci la temperatura del cambiamento:");
            temperatura = double.Parse(Console.ReadLine());

            m = (a + b + c) / 3;

            if(m <= temperatura){
                Console.WriteLine("Accendo il riscaldamento");
            }
            else{
                Console.WriteLine("Spengo il riscaldamento");
            }

            Console.ReadKey();
        }
    }
}
