using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class Loops
    {
        public static void Exercise1()
        {
            double[,] table = { { 1, 3.58, 0.05, 10, 2 }, { 2, 9.61, 0.05, 25, 5 }, { 3, 8.52, 0.08, 18, 3 }, { 4, 10.25, 0.08, 36, 6 }, { 5, 6.17, 0.23, 4, 1 } };
            for(var i=0; i<table.GetLength(0);i++)
            {
                Console.WriteLine($"Wartośc brutto towaru o id: {i+1} to: {Math.Round((table[i,1] * table[i,2] + table[i, 1]),2,MidpointRounding.ToEven)}");
            }
            Console.WriteLine("");
            for (var i = 0; i < table.GetLength(0); i++)
            {
                Console.WriteLine($"Wartośc magazynowa towaru o id: {i + 1} to: {table[i, 3]* table[i, 4]} sztuk.");
            }
            Console.WriteLine("");
            for (var i = 0; i < table.GetLength(0); i++)
            {
                Console.WriteLine($"Towar o id: {i + 1}, cena netto: {table[i, 1]}, stawka VAT: {table[i, 2]}, cena brutto: {Math.Round((table[i, 1] * table[i, 2] + table[i, 1]), 2, MidpointRounding.ToEven)}, cena netto za pudełko:  {Math.Round((table[i, 1] * table[i, 3]), 2, MidpointRounding.ToEven)}, cena brutto za pudełko:  {Math.Round(((table[i, 1] * table[i, 3])*0.23+ table[i, 1] * table[i, 3]), 2, MidpointRounding.ToEven)}");
            }
        }

        public static void Exercise2()
        {
            int number;

            Console.WriteLine("Użytkowniku podaj liczbę do sprawdzenia");
            number = Int32.Parse(Console.ReadLine());

            Console.Write($"Liczba: {number} dzieli się bez reszty przez: ");

            for(int i = 1; i <= number; i++)
            {
                if(number%i==0)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine();
        }
    }
}
