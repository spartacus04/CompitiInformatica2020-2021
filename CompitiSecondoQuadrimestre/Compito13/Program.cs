using System;

namespace Compito13
{
    class Program
    {
        static void Main(string[] args)
        {
            int polygons = Convert.ToInt32(inputData(0, "Inserisci il numero di poligoni"));
            double maxArea = 0;

            for (int i = 0; i < polygons; i++)
            {
                double areaValue = polygon(i);
                if(areaValue > maxArea){
                    maxArea = areaValue;
                }
            }

            Console.WriteLine("L'area più grande è " + maxArea);
        }


        static double polygon(int index){
            int lati = Convert.ToInt32(inputData(2, "inserisci il numero di lati del poligono " + (index + 1)));
            double w = inputData(0, "Inserisci la lunghezza di un lato del poligono " + (index + 1));
            double h = inputData(0, "Inserisci l'altezza del poligono del poligono " + (index + 1));

            double perimeterValue = perimeter(w, lati);
            double areaValue = area(w, lati, perimeterValue);

            Console.WriteLine();
            Console.WriteLine("L'area del poligono " + (index + 1) + " è " + Math.Round(areaValue));
            Console.WriteLine("Il perimetro del poligono " + (index + 1) + " è " + perimeterValue);
            Console.WriteLine();
            return areaValue;
        }

        static double inputData(int min, string messaggio){
            double input;
            do
            {
                Console.WriteLine(messaggio);
                input = double.Parse(Console.ReadLine());
            } while (input <= min);
            return input;
        }

        static double area(double w, int lati, double perimeter){
            double a = (w / 2) * Math.Tan((Math.PI * (lati - 2)) / (2 * lati));
            double areaValue = (a * perimeter) / 2;
            return areaValue;
        }

        static double perimeter(double w, int lati){
            return w * lati;
        }

    }
}
