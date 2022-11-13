using ALXCourse.Lessons.M2.L2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L2.Classes//interfejsy to projekt publicznych metod
{//implementujemy tutaj klase Hello która ma metody z interfejsu IHello
    public class Hello : IHello //jak nie napiszemy metod w srodku to wyrzuci błąd, że nie implementujemy metod które mówiliśmy, że będą implementowane klikamy alt+enter
    {
        public void SayGoodMorning(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }

        public void SayGoodMorning()
        {
            Console.WriteLine("Good Morning");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
