using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class EnumsAndLists
    {
        public enum Months
        {
            STYCZEŃ,
            LUTY,
            MARZEC,
            KWIECIEŃ,
            MAJ,
            CZERWIEC,
            LIPIEC,
            SIERPIEŃ,
            WRZESIEŃ,
            PAŹDZIERNIK,
            LISTOPAD,
            GRUDZIEŃ
        }
        public static void Exercise1()
        {
            Console.WriteLine("Wszystkie miesiące z wykorzystaniem enums: ");
            foreach(var item in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(item);
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Wszystkie miesiące z wykorzystaniem list: ");

            List<Months> monthsList = new List<Months>();

            monthsList.Add(Months.STYCZEŃ);
            monthsList.Add(Months.LUTY);
            monthsList.Add(Months.MARZEC);
            monthsList.Add(Months.KWIECIEŃ);
            monthsList.Add(Months.MAJ);
            monthsList.Add(Months.CZERWIEC);
            monthsList.Add(Months.LIPIEC);
            monthsList.Add(Months.SIERPIEŃ);
            monthsList.Add(Months.WRZESIEŃ);
            monthsList.Add(Months.PAŹDZIERNIK);
            monthsList.Add(Months.LISTOPAD);
            monthsList.Add(Months.GRUDZIEŃ);

            foreach (Months item in monthsList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
