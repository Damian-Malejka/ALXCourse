using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMaterialProjectApp.Interfaces
{
    public interface IContract
    {
        public double Salary();
        public void ChangeOvertime(double overtime);
        public void ChangeBasicSalary(double basicSalary);
    }
}
