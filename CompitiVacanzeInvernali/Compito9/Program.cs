using System;

namespace Compito9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il primo numero");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il secondo numero");
            double numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire l'operatore");
            char operatore = Convert.ToChar(Console.ReadLine());

            double risultato;

            switch(operatore){
                case '+':
                    risultato = numero1 + numero2;
                    Console.WriteLine("Il risultato è " + risultato);
                    break;
                case '-':
                    risultato = numero1 - numero2;
                    Console.WriteLine("Il risultato è " + risultato);
                    break;
                case '*':
                    risultato = numero1 * numero2;
                    Console.WriteLine("Il risultato è " + risultato);
                    break;
                case '/':
                    risultato = numero1 / numero2;
                    Console.WriteLine("Il risultato è " + risultato);   
                    break;
                default:
                    Console.WriteLine("undefined");
                    break;
            }

            Console.ReadKey();
        }
    }
}
