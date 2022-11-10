using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class Operators
    {
        public static void Exercise1()
        {
            int a = 3;
            int b = 6;
            int c = 15;
            var wynik = ((a ^ b) / 2) % c;
            Console.WriteLine("Wynik działania to: " + wynik);
            Console.WriteLine("Powyższy wynik powiększony o 5 jest: " + ((wynik + 5 > a) ? "wiekszy " : "mniejszy ") + "od a równego: " + a);
        }
        internal static bool FirstDeMorganLaw(bool p, bool q)
        {
            return ((!(p|q))==(!p&!q));
        }
        internal static bool SecondDeMorganLaw(bool p, bool q)
        {
            return ((!(p & q)) == (!p | !q));
        }
        public static void Exercise2()
        {
            Console.WriteLine("Method FirstDeMorganLaw for p=false q=false is: " + FirstDeMorganLaw(false,false));
            Console.WriteLine("Method FirstDeMorganLaw for p=false q=true is: " + FirstDeMorganLaw(false, true));
            Console.WriteLine("Method FirstDeMorganLaw for p=true q=false is: " + FirstDeMorganLaw(true, false));
            Console.WriteLine("Method FirstDeMorganLaw for p=true q=true is: " + FirstDeMorganLaw(true, true));

            Console.WriteLine("Method SecondDeMorganLaw for p=false q=false is: " + SecondDeMorganLaw(false, false));
            Console.WriteLine("Method SecondDeMorganLaw for p=false q=true is: " + SecondDeMorganLaw(false, true));
            Console.WriteLine("Method SecondDeMorganLaw for p=true q=false is: " + SecondDeMorganLaw(true, false));
            Console.WriteLine("Method SecondDeMorganLaw for p=true q=true is: " + SecondDeMorganLaw(true, true));
        }

    }
}
