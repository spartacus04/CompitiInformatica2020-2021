using System;

namespace Compito6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, a1 = 0, b1 = 0, c1 = 0, d1 = 0;
            Console.WriteLine("Inserire il numero 1:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il numero 2:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il numero 3:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il numero 4:");
            d = int.Parse(Console.ReadLine());

            if(a % 2 == 1){
                a1 = a;
                a = 0;
            }
            if(b % 2 == 1){
                b1 = b;
                b = 0;
            }
            if(c % 2 == 1){
                c1 = c;
                c = 0;
            }
            if(d % 2 == 1){
                d1 = d;
                d = 0;
            }

            int NumeriPari = a + b + c + d;
            int NumeriDispari = a1 + b1 + c1 + d1;

            Console.WriteLine("La somma dei numeri pari è " + NumeriPari);
            Console.WriteLine("La somma dei numeri DISpari è " + NumeriDispari);
            Console.ReadKey();
        }
    }
}
