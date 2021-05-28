using System;

namespace Compito17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = randomVect();
            int[] b = randomVect();
            int[] c = new int[100];
            int tot = 0;

            double med = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] > b[i]) c[i] = a[i];
                else c[i] = b[i];

                med += c[i];
            }

            med /= c.Length;

            for (int i = 0; i < c.Length; i++)
            {
                if(c[i] > med) tot++;
            }

            System.Console.WriteLine("La media del vettore c è " + med);
            System.Console.WriteLine("Ci sono " + tot + " numeri sopra la media");
            Console.ReadKey();
        }


        static int[] randomVect(){
            Random rand = new Random();
            int[] vect = new int[100];
            for (int i = 0; i < vect.Length; i++)
            {
                vect[i] = rand.Next(0, 101);
            }

            return vect;
        }
    }
}
