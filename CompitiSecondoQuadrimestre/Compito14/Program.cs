using System;

namespace Compito14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, operations = 0, sel;
            input(ref a, ref b);
            do
            {
                sel = showMenu();
                System.Console.WriteLine();
                switch(sel){
                    case 1:
                        input(ref a, ref b);
                        break;
                    case 2:
                        countEvenBetween(a, b);
                        break;
                    case 3:
                        triangleArea(a, b);
                        break;
                    case 4:
                        media(a, b);
                        break;
                    case 5:
                        swapInput(ref a, ref b);
                        break;
                    case 6:
                        multiplication(a, b);
                        break;
                    case 7:
                        showOperations(operations);
                        break;
                }
                System.Console.WriteLine();
                operations++;
            } while (sel != 8);
        }


        static int inputData(string messaggio){
            int input;
            do
            {
                Console.WriteLine(messaggio);
                input = int.Parse(Console.ReadLine());
            } while (input <= 0);
            return input;
        }

        static int showMenu(){
            int sel;
            do
            {
                System.Console.WriteLine("Scegli un opzione: ");
                System.Console.WriteLine("1. Inserisci il valore di a e b");
                System.Console.WriteLine("2. Visualizza i numeri pari compresi tra a e b");
                System.Console.WriteLine("3. Visualizza l'area del triangolo con base a e altezza b");
                System.Console.WriteLine("4. La media di tutti i numeri compresi tra a e b");
                System.Console.WriteLine("5. Scambia il valore di a e b");
                System.Console.WriteLine("6. Prodotto di a e b calcolato con somme successive");
                System.Console.WriteLine("7. Visualizza il numero di operazioni eseguite fino ad ora");
                System.Console.WriteLine("8. Esci");
                sel = int.Parse(Console.ReadLine());
            } while (sel < 1 && sel > 8);
            return sel;
        }

        static void input(ref int a, ref int b){
            a = inputData("Inserisci il valore di A: ");
            b = inputData("Inserisci il valore di B: ");
        }

        static void countEvenBetween(int a, int b){
            for (int i = a; i < b; i++)
            {
                if(i % 2 == 0) Console.WriteLine(i);
            }
        }

        static void triangleArea(int a, int b){
            Console.WriteLine("L'area del triangolo è uguale a " + Math.Round((double)((a * b)/ 2), 2));
        }

        static void media(int a, int b){
            int m = 0, i = 0;
            for(; a < b; i++){
                System.Console.WriteLine(a);
                m += a;
                a++;
            }
            Console.WriteLine("La media è " + (double)(m / i));
        }

        static void swapInput(ref int a, ref int b){
            int temp = a;
            a = b;
            b = temp;
        }

        static void multiplication(int a, int b){
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
            }
            Console.WriteLine("Il prodotto è uguale a " + sum);
        }
 
        static void showOperations(int i){
            System.Console.WriteLine("Il numero di operazioni eseguite è " + i);
        }
    }
}
