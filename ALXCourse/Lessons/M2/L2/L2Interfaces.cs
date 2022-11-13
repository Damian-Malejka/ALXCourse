using ALXCourse.Lessons.M2.L2.Classes;
using ALXCourse.Lessons.M2.L2.Interfaces;

namespace ALXCourse.Lessons.M2.L2
{
    public class L2Interfaces
    {
        public static void Run()
        {
            IHello helloService = new PolishHello();

            helloService.SayGoodMorning("Damian");
            helloService.SayGoodMorning();
            helloService.SayHello("Damian");
            helloService.SayHello();

            Console.WriteLine();
            helloService = new Hello();

            helloService.SayGoodMorning("Damian");
            helloService.SayGoodMorning();
            helloService.SayHello("Damian");
            helloService.SayHello();


        }
    }
}
