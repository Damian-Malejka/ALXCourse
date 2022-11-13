using CommonFunctionalities.Services.Interfaces;

namespace CommonFunctionalities.Services
{
    public class TaxService:ITaxService
    {
        private const double VatPercentage = 0.23;
        private const double GovernmentPercentage = 0.17;
        /*
         Enkapsulacja polega na tym ze jakbysmy chcieli policzyc podatego to mamy dostep tylko do CalculateTax a*/ 
        public double CalculateTax(double income)
        {
   
            var vatTax = CalculateVat(income);
            var govermentTax = CalculateGovernmentTax(income, vatTax);
            return vatTax + govermentTax;
        }
        private double CalculateVat(double income)
        {
            return income * VatPercentage;
        }
        private double CalculateGovernmentTax(double income, double vatTax)
        {
            return (income - vatTax) * GovernmentPercentage;
        }
    }
}
