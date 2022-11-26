using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments.ExerciseClassesAndConstructor.Classes
{
    public class CarPrice
    {
        public double NettoPrice;
        public double AdditionalPrice;
        public double VatRate;

        public CarPrice(double nettoPrice, double additionalPrice, double vatRate)
        {
            NettoPrice = nettoPrice;
            AdditionalPrice = additionalPrice;
            VatRate = vatRate;
        }

        public double CarCalculatorPrice()
        {
            return (NettoPrice + AdditionalPrice) * VatRate + NettoPrice + AdditionalPrice;
        }
    }
}
