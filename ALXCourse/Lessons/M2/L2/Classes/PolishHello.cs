using ALXCourse.Lessons.M2.L2.Interfaces;

namespace ALXCourse.Lessons.M2.L2.Classes
{
    internal class PolishHello : IHello //czyli mamy dwie klasy Hello i PolishHello korzystajace z tego samego interfejsu hello
    {
        public void SayGoodMorning(string name)
        {
            Console.WriteLine("Dzień Dobry " + name);
        }

        public void SayGoodMorning()
        {
            Console.WriteLine("Dzień Dobry");
        }

        public void SayHello()
        {
            Console.WriteLine("Cześć");
        }

        public void SayHello(string name)
        {
            Console.WriteLine("Cześć " + name);
        }
    }
}
