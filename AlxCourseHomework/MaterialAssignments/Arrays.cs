using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class Arrays
    {
        public static void Exercise1()
        {
            string[] names = { "biurko", "stol", "krzeslo", "zegar" };
            double[] prices = { 450, 499.99, 100, 49.90 };
            int choice;
            Console.WriteLine("Użytkowniku podaj numer towaru od 1 od 4 aby wyświetlić jego informacje");
            choice = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{names[choice - 1]}: cena netto: {Math.Round((prices[choice - 1] / 1.23), 2, MidpointRounding.ToEven)} cena brutto: {prices[choice - 1]}zł");
        }

        public static void Exercise2()
        {
            int[,] matrix = new int[3, 3];
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }

        public static void Exercise3()
        {
            Console.Write("Podaj ile liczb bedziesz wprowadzał do tablicy: ");
            var numberElements = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Podaj wartość stałej do dodawania: ");
            var constToAdd = double.Parse(Console.ReadLine());

            double[] arrayBin = new double[numberElements];

            for (var i = 0; i < numberElements; i++)
            {
                Console.Write($"Podaj element tablicy numer: {i + 1}: ");
                arrayBin[i] = constToAdd + double.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Wynikowa tablica:");
            for (var i = 0; i < numberElements; i++)
            {
                Console.Write(arrayBin[i] + ", ");
            }
        }
    }   
}
