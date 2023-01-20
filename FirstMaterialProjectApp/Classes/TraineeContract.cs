using FirstMaterialProjectApp.Interfaces;

namespace FirstMaterialProjectApp.Classes
{
    public class TraineeContract : IContract
    {
        public double BasicSalary;

        public TraineeContract()
        {
            BasicSalary = 1000;
        }
        public TraineeContract(double basicSalary)
        {
            BasicSalary = basicSalary;
        }

        public void ChangeBasicSalary(double basicSalary)
        {
            BasicSalary = basicSalary;
        }

        public void ChangeOvertime(double overtime)
        {
            throw new NotImplementedException();
        }

        public double Salary()
        {
            return BasicSalary;
        }
    }
}
