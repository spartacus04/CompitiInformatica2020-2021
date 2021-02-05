using System;

namespace Compito9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il primo numero: ");
            int a = int.Parse(Console.ReadLine());

            int b;
            do
            {
                Console.WriteLine("Inserire il secondo numero:" );
                b = int.Parse(Console.ReadLine());
            } while (b <= 0);

            int i = 0;  //Cont
            
            while(i < b){
                int num;
                do
                {
                    Console.WriteLine("Inserire un numero minore di " + a + ": ");
                    num = int.Parse(Console.ReadLine());
                } while (num >= a);
                i++;
            }

            Console.WriteLine("Sono stati inseriti " + b + " numeri < di " + a);
            Console.ReadKey();
        }
    }
}
