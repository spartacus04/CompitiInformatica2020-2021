using System;

namespace Compito16
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp;

            do
            {
                inp = menu();

                switch(inp){
                    case 1:
                        int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
                        double res = dist(ref x1, ref x2, ref y1, ref y2);

                        System.Console.WriteLine($"La distanza tra il punto A({x1};{y1}) e il punto B({x2};{y2}) è {res}");
                        break;
                    case 2:
                        repeat();
                        break;
                    case 3:
                        tab();
                        break;
                    case 4:
                        ranNumbers();
                        break;
                    case 5:
                        System.Console.WriteLine("L'importo minimo è " + minImport() + " euro");
                        break;
                    case 6:
                        double a;
                        do{
                            System.Console.WriteLine("Inserisci il prezzo di un prodotto");
                            a = double.Parse(Console.ReadLine());
                        } while (a < 0);

                        int per;
                        do
                        {
                            per = input("Inserisci lo sconto");
                        } while (per > 100);

                        System.Console.WriteLine("Il prezzo del prodotto scontato è " + discount(a, per));

                        break;
                }

            } while (inp != 7);
        }

        static double discount(double input, int percent){
            return input - (input / 100 * percent);
        }

        static int minImport(){
            int a = input("Inserisci il numeri di acquisti:");
            
            int min = int.MaxValue;

            for (int i = 0; i < a; i++)
            {
                int inp = input("Inserisci l'importo del prodotto " + i);
                if(inp < min)
                    min = inp;
            }
            return(min);
        }
     
        static void ranNumbers(){
            int a = input("Quanti numeri sono vogliono essere generati?");

            for (int i = 0; i < a; i++)
            {
                System.Console.WriteLine(ranBetween(ranBetween(20, 31), ranBetween(20, 31)));
            }
        }

        static int ranBetween(int min, int max){
            if(min > max)
                swap(ref min, ref max);
            return new Random().Next(min, max +1 );
        }

        static void tab(){

            void tabellina(int num){
                for (int i = 0; i <= 10; i++)
                {
                    System.Console.WriteLine(num * i);
                }
            }

            int a = input("Inseirisci il primo numero");
            int b = input("Inseirisci il secondo numero");
            int c = input("Inseirisci il terzo numero");

            if(a > b && a > c){
                tabellina(a);
            }
            else if(b > a && b > c){
                tabellina(b);
            }
            else{
                tabellina(c);
            }
        }

        static void repeat(){
            int a = input("Inserisci il primo numero");
            int b = input("Inserisci il secondo numero");

            if(b > a)
                swap(ref a, ref b);

            for (int i = 0; i < a; i++)
                System.Console.WriteLine(b);
        }

        static void swap(ref int a, ref int b){
            int temp = a;
            a = b;
            b = temp;
        }

        static double dist(ref int x1, ref int x2, ref int y1, ref int y2){
            Random ran = new Random();
            x1 = ran.Next(0, 501);
            x2 = ran.Next(0, 501);
            y1 = ran.Next(0, 501);
            y2 = ran.Next(0, 501);

            return Math.Sqrt(Math.Pow((double)Math.Abs(x1 - x2), 2) + Math.Pow((double)Math.Abs(y1 - y2), 2));
        }

        static int input(string mes){
            int a;
            do{
                System.Console.WriteLine(mes);
                a = int.Parse(Console.ReadLine());
            } while (a < 0);
            return a;
        }

        static int menu(){
            int a;
            do
            {
                a = input("Seleziona un opzione:\n1. Distanza tra 2 punti nel piano cartesiano\n2. Visualizza il numero b ripetuto per il numero a\n3. Tabellina di un numero\n4. Numeri casuali tra a e b\n5. Importo minore da lista di importi\n6. Calcolo sconto\n7. Esci");
            } while (a > 7);
            return a;
        }
    }
}
