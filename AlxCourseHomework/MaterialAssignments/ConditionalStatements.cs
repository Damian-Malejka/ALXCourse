using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class ConditionalStatements
    {
        public static void Exercise1()
        {
            Console.Write("Kwota za zakupy: ");
            double priceSum = Double.Parse(Console.ReadLine());
            if(priceSum>=100)
            {
                priceSum -= priceSum * 0.15;
            }
            else if((priceSum>=60) && (priceSum<100))
            {
                priceSum -= priceSum * 0.05;
            }
            Console.WriteLine($"Kwota do zapłaty po rabacie to: {priceSum}");
            
        }
        public static void Exercise2()
        {
            Console.Write("Kwota za zakupy: ");
            double priceSum = Double.Parse(Console.ReadLine());
            switch(priceSum)
            {
                case >= 100:
                    priceSum -= priceSum * 0.15;
                break;
                case >= 60:
                    priceSum -= priceSum * 0.05;
                break;
            }
            Console.WriteLine($"Kwota do zapłaty po rabacie to: {priceSum}");
        }
    }
}
