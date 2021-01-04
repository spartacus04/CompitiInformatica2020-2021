using System;

namespace Compito8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire un voto in forma letterale: ");
            char voto = Convert.ToChar(Console.ReadLine());

            switch(voto){
                case 'a':
                    Console.WriteLine("Il voto corrisponde a ottimo");
                    break;
                case 'b':
                    Console.WriteLine("Il voto corrisponde a molto buono");
                    break;
                case 'c':
                    Console.WriteLine("Il voto corrisponde a buono");
                    break;
                case 'd':
                    Console.WriteLine("Il voto corrisponde a insufficiente");
                    break;
                case 'e':
                    Console.WriteLine("Il voto corrisponde a gravemente insufficiente");
                    break;
                default:
                    Console.WriteLine("lettera non valida");
                    break;
            }

            Console.ReadKey();
        }
    }
}
