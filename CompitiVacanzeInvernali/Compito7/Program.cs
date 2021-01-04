using System;

namespace Compito7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire un mese (1-12)");
            int mese = int.Parse(Console.ReadLine());
            int giorno;


            switch(mese){
                case 1:
                    Console.WriteLine("La stagione è Inverno");
                    break;
                case 2:
                    Console.WriteLine("La stagione è Inverno");
                    break;
                case 3:
                    Console.WriteLine("Inserire un giorno");
                    giorno = int.Parse(Console.ReadLine());

                    if(giorno <= 20){
                        Console.WriteLine("La stagione è Inverno");
                    }
                    else{
                        Console.WriteLine("La stagione è Primavera");
                    }
                    break;
                case 4:
                    Console.WriteLine("La stagione è Primavera");
                    break;
                case 5:
                    Console.WriteLine("La stagione è Primavera");
                    break;
                case 6:
                    Console.WriteLine("Inserire un giorno");
                    giorno = int.Parse(Console.ReadLine());

                    if(giorno <= 20){
                        Console.WriteLine("La stagione è Primavera");
                    }
                    else{
                        Console.WriteLine("La stagione è Estate");
                    }
                    break;
                case 7:
                    Console.WriteLine("La stagione è Estate");
                    break;
                case 8:
                    Console.WriteLine("La stagione è Estate");
                    break;
                case 9:
                    Console.WriteLine("Inserire un giorno");
                    giorno = int.Parse(Console.ReadLine());

                    if(giorno <= 20){
                        Console.WriteLine("La stagione è Estate");
                    }
                    else{
                        Console.WriteLine("La stagione è Autunno");
                    }
                    break;
                case 10:
                    Console.WriteLine("La stagione è Autunno");
                    break;
                case 11:
                    Console.WriteLine("La stagione è Autunno");
                    break;
                case 12:
                    Console.WriteLine("Inserire un giorno");
                    giorno = int.Parse(Console.ReadLine());

                    if(giorno <= 20){
                        Console.WriteLine("La stagione è Autunno");
                    }
                    else{
                        Console.WriteLine("La stagione è Inverno");
                    }
                    break;
                default:
                    Console.WriteLine("Il mese non è corretto");
                    break;
            }

            Console.ReadKey();
        }
    }
}
