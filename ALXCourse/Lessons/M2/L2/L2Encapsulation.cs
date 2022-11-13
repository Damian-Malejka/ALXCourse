using CommonFunctionalities.Services;

namespace ALXCourse.Lessons.M2.L2
{
    public class L2Encapsulation
    {
        public static void Run()// tak naprawde na zewnatrz potrzebujemy tylko run reszte w srodku uzywamy
        {
            var taxService = new TaxService();
            var income = 5000;
            var tax = taxService.CalculateTax(income);//zgodnie z enkapsulacja nie mamy dostepu do innych metod
            //var tax2 = taxService.CalculateGovernmentTax(income,2);//tu brak dostepu bo bylo private
            Present(tax, income);
        }
        private static void Present(double tax, double income) //public ma sens tylko sens gdy chcemy wywołac ta metodę na zewnątrz
        {
            Console.WriteLine($"Income: {income}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Netto: {income-tax}");

        }
    }
}
