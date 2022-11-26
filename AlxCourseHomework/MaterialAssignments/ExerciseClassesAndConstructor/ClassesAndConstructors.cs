using AlxCourseHomework.MaterialAssignments.ExerciseClassesAndConstructor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments.ExerciseClassesAndConstructor
{
    public class ClassesAndConstructors
    {
        public static void Exercise1()
        {
            Console.Write("Użytkowniku podaj cenę netto: ");
            var nettoPrice = double.Parse(Console.ReadLine());
            Console.Write("\nUżytkowniku podaj cenę netto za dodatki: ");
            var additionalPrice = double.Parse(Console.ReadLine());
            Console.Write("\nUżytkowniku podaj stawkę VAT: ");
            var vatRate = double.Parse(Console.ReadLine());

            var carPrice = new CarPrice(nettoPrice, additionalPrice, vatRate);

            Console.WriteLine($"\n\nKwota brutto do zapłaty to: {carPrice.CarCalculatorPrice()}zł");

        }

        public static void Exercise2()
        {
            string name;
            Console.Write("Wprowadź swoje imię: ");
            name = Console.ReadLine();
            if(name.Substring(name.Length - 1) == "a")
            {
                Console.WriteLine("Dzień Dobry Pani!");
            }
            else
            {
                Console.WriteLine("Dzień Dobry Panu!");
            }
            
        }
    }
}
