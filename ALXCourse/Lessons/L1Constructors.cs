using ALXCourse.Lessons.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons
{
    public class L1Constructors
    {
        public static void Test()
        {
            //var spider = new Spider(); //mamy zdefiniowaną klase spider wiec mozemy uzyc tak i on nam sam dobierze

            var x = 1; //utworzy nam integer;

            // x = 9999999999; //to wyrzuci błąd bo przekraczamy int nie robi automatycznej konwersji


            var spider = new Spider(); //tutaj korzystamy z pustego konstruktora ktory sami musimy dodac, bo jak dodamy niepusty konstruktor to domyslny jest kasowany, czyli koniecznie musimy utworzyc pusty dodatkowo
            spider.Color = "black";
            spider.Species = "Black Window";
            spider.IsVenomous = true;
            spider.Sex = "female";

            var redSpider = new Spider("red","Tarantula",true,"male"); //tutaj korzystamy z tego drugiego konstruktora

            var blueSpider = new Spider("blue", "Goliath");

            var greenSpider = new Spider("green", true);

        }
    }
}
