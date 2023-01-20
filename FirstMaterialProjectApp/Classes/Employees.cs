using FirstMaterialProjectApp.Enums;
using FirstMaterialProjectApp.Interfaces;

namespace FirstMaterialProjectApp.Classes
{
    public class Employees
    {
        public string Name;
        public string Surname;
        public IContract Contract;

        public Employees(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Contract = new TraineeContract();

        }

        public void ChangeContract(ContractTypes contract)
        {
            if (contract == ContractTypes.FULLEMPLOYEECONTRACT)
            {
                Contract = new FullEmployeeContract();
            }
        }

        public double EmployeeSalary()
        {
            return Contract.Salary();
        }

        public override string ToString()
        {
            return Name.ToString() + " " +Surname.ToString() + " zarabia " + EmployeeSalary().ToString() + "zl";
        }
    }
}
