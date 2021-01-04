using System;

namespace Compito4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tipo di triangolo\n1 = rettangolo\n2 = isoscele\n3 = equilatero\naltro = generico");
            int TipoTriangolo = int.Parse(Console.ReadLine());


            int Base, altezza, ipotenusa, perimetro;
            double area;
            switch(TipoTriangolo){
                case 1:
                    //Rettangolo
                    Console.WriteLine("Inserire la base:");
                    Base = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserire l'altezza:");
                    altezza = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserire l'ipotenusa:");
                    ipotenusa = int.Parse(Console.ReadLine());

                    perimetro = Base + altezza + ipotenusa;
                    area = (Base * altezza) / 2;

                    Console.WriteLine("Il perimetro vale " + perimetro);
                    Console.WriteLine("L'area vale " + area);
                    break;
                case 2:
                    //Isoscele
                    Console.WriteLine("Inserire la base:");
                    Base = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserire l'altezza:");
                    altezza = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserire il lato:");
                    ipotenusa = int.Parse(Console.ReadLine());

                    perimetro = Base + ipotenusa * 2;
                    area = (Base * altezza) / 2;

                    Console.WriteLine("Il perimetro vale " + perimetro);
                    Console.WriteLine("L'area vale " + area);
                    break;
                case 3:
                    //Equilatero
                    Console.WriteLine("Inserire la base:");
                    Base = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserire l'altezza:");
                    altezza = int.Parse(Console.ReadLine());

                    perimetro = Base * 3;
                    area = (Base * altezza) / 2;

                    Console.WriteLine("Il perimetro vale " + perimetro);
                    Console.WriteLine("L'area vale " + area);
                    break;
                default:
                    //Generico
                    int lato;

                    Console.WriteLine("Inserire la primo lato(base):");
                    Base = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserire il secondo lato:");
                    ipotenusa = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserire il terzo lato:");
                    lato = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserire l'altezza:");
                    altezza = int.Parse(Console.ReadLine());

                    perimetro = Base + ipotenusa + lato;
                    area = (Base * altezza) / 2;

                    Console.WriteLine("Il perimetro vale " + perimetro);
                    Console.WriteLine("L'area vale " + area);
                    break;
            }
            Console.ReadKey();
        }
    }
}
