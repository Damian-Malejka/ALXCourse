using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseFormApp.Exceptions;

namespace CourseFormApp
{
    public class ThrowExceptionExamle
    {
        public void Run()//to metoda rzucające przykładowy wyjątek
        {
            MessageBox.Show("Throwing exception");
            throw new OurOwnException("Do not click that button!");//rzuć wyjątek naszej klasy
        }
    }
}
