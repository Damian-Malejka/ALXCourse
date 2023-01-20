using FirstMaterialProjectApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMaterialProjectApp.Classes
{
    public class FullEmployeeContract : IContract
    {
        public double BasicSalary;
        public double Overtime;

        public FullEmployeeContract()
        {
            BasicSalary = 5000;
            Overtime = 0;
        }

        public FullEmployeeContract(double basicSalary, double overtime)
        {
            BasicSalary = basicSalary;
            Overtime = overtime;
        }

        public void ChangeBasicSalary(double basicSalary)
        {
            BasicSalary = basicSalary;
        }

        public void ChangeOvertime(double overtime)
        {
            Overtime = overtime;
        }

        public double Salary()
        {
            return (BasicSalary + Overtime*(BasicSalary/60));
        }
    }
}
