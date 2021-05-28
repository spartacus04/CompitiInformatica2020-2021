using System;

namespace Compito19
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temps = randomVect(input("Inserisci il numero di giorni da misurare"));
            
            Double med = 0, maxTemp = -273.15;

            for (int i = 0; i < temps.Length; i++)
            {
                System.Console.WriteLine("Giorno " + (i + 1) + ": " + temps[i]);
                med += temps[i];
                if(temps[i] > maxTemp) maxTemp = temps[i];
            }

            med /= temps.Length;

            System.Console.WriteLine("La media delle temperature è " + med);
            System.Console.WriteLine("La temperatura massima è " + maxTemp);

            double above = inputD("Inserisci un numero per visualizzare le temperature maggiori");

            System.Console.WriteLine("Le temperature maggiori di " + above + " sono:");
            for (int i = 0; i < temps.Length; i++)
            {
                if(temps[i] > above) System.Console.WriteLine(temps[i]);
            }

            Console.ReadKey();
        }

        static double inputD(string msg){
            double a;
            do
            {
                System.Console.WriteLine(msg);
                a = double.Parse(Console.ReadLine());
            } while (a < -273.15);
            return a;
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

        static double[] randomVect(int size){
            Random rand = new Random();
            double[] vect = new double[size];
            for (int i = 0; i < vect.Length; i++)
            {
                vect[i] = inputD("Inserisci la temperatura del giorno " + (i + 1));
            }

            return vect;
        }
    }
}
