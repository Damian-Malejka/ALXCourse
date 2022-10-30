using System.Transactions;

namespace ALXCourse.Lessons.L1
{
    public class L1SimpleVariables
    {
        public static void Run()
        {
            bool whySoSerious = true;
            Console.WriteLine(whySoSerious); //nie pozwala wyświetlić wartości niezdefiniowanej

            int x = 12;
            Console.WriteLine(x);

            double y = 1.22;
            float z = 1.22f;

            char znak = 'g';
        }
    }
}
