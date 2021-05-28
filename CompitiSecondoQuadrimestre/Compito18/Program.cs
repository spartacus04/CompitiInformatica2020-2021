using System;

namespace Compito18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = {"gennaio", "febbraio", "marzo", "aprile", "maggio", "giugno", "luglio", "agosto", "settembre", "ottobre", "novembre", "dicembre"};
            int[] max = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            int g = input("Inserisci il giorno");
            int m = input("Inserisci il mese (1-12)");

            if(m <= 12 && g <= max[m - 1])  Console.WriteLine("La data " + g + " "+ months[m-1] + " è valida");
            else Console.WriteLine("Data non valida");
            
            Console.ReadKey();
        }

        static int input(string msg){
            int a;
            do
            {
                System.Console.WriteLine(msg);
                a = int.Parse(Console.ReadLine());
            } while (a < 0);
            return a;
        }
    }
}
