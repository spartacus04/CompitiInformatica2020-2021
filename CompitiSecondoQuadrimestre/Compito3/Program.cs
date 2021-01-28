using System;

namespace Compito3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double speso = 0;
            double residuo = 500;
            do
            {
                Console.WriteLine("Inserire un acquisto");
                double aquisto = double.Parse(Console.ReadLine());

                i++;
                residuo -= aquisto;
                speso += aquisto;
            } while (residuo > 0);

            Console.WriteLine("\nHai fatto " + i + " acquisti");
            Console.WriteLine("Hai speso " + speso + " euro");

            if(residuo == 0){
                Console.WriteLine("Hai speso tutto il bonus e non devi versare nulla");
            }
            else{
                Console.WriteLine("Devi versare " + (0 - residuo) + " euro");
            }

            Console.ReadKey();
        }
    }
}
