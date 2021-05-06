using System;

namespace Compito15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sel;
            do
            {
                sel = showMenu();
                Console.WriteLine();
                switch(sel){
                    case 1:
                        rette();
                        break;
                    case 2:
                    temperature();
                        break;
                }
                Console.WriteLine();
            } while (sel != 3);
        }


        static double inputData(string messaggio){
            double input;
            do
            {
                Console.WriteLine(messaggio);
                input = double.Parse(Console.ReadLine());
            } while (input <= 0);
            return input;
        }

        static int showMenu(){
            int sel;
            do
            {
                Console.WriteLine("Scegli un opzione: ");
                Console.WriteLine("1. Verificare tramite coefficienti angolari la relazione tra 2 rette");
                Console.WriteLine("2. Convertire altre temperature in gradi celsius");
                Console.WriteLine("3. Esci dal programma");
                sel = int.Parse(Console.ReadLine());
            } while (sel < 1 && sel > 3);
            return sel;
        }

        static void rette(){
            double cof = inputData("Inserisci il coefficiente angolare della retta 1");
            double cof2 = inputData("Inserisci il coefficiente angolare della retta 2");

            if(cof == cof2){
                Console.WriteLine("Le rette sono parallele");
            }
            else if(cof == (-(1 / cof2))){
                Console.WriteLine("Le rette sono perpendicolari");
            }
            else{
                Console.WriteLine("Le rette sono incidenti");
            }
        }
        static void temperature(){
            double u;
            do
            {
                u = inputData("Inserisci l'unità di misura desiderata:\n1. Fahrenheit\n2. Kelvin");
            } while (u > 2);

            double temp = inputData("Inserisci la temperatura: ");

            if(u == 1){
                Console.WriteLine("Il valore della temperatura in celsius è " + ((temp * 1.8) +32));
            }
            else{
                Console.WriteLine("Il valore della temperatura in celsius è " + (273.15 + temp));
            }

        }
    }
}
