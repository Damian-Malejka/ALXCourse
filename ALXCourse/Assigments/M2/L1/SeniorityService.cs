using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Assigments.M2.L1
{
    public class SeniorityService
    {
        public List<Employee> JuniorEmployees;
        public List<Employee> MidEmployees;
        public List<Employee> SeniorEmployees;

        public SeniorityService()
        {
            JuniorEmployees = new List<Employee>();
            MidEmployees = new List<Employee>();
            SeniorEmployees = new List<Employee>();
        }
        public void ClassifySeniorityBySalary(Employee employee)
        {
            if (employee.Salary < 5000)
            {
                JuniorEmployees.Add(employee);
            }
            else if (employee.Salary >= 5000 && employee.Salary < 10000)
            {
                MidEmployees.Add(employee);
            }
            else
            {
                SeniorEmployees.Add(employee);
            }
        }
        public void ClassifySeniorityByExperience(Employee employee)
        {
            if (employee.Experience < 3)
            {
                JuniorEmployees.Add(employee);//dodawanie pracownika do listy
            }
            else if (employee.Experience >= 3 && employee.Experience < 10)
            {
                MidEmployees.Add(employee);
            }
            else
            {
                SeniorEmployees.Add(employee);
            }
        }

        public void ClearClassifyLists()
        {
            JuniorEmployees.Clear();//czyszczenie zawartości całej listy
            MidEmployees.Clear();//żeby usunąć jeden wpis to np MidEmployees.Remove(employee);
            SeniorEmployees.Clear();
        }
    }
}
