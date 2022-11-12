using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Assigments.M2
{
    public static class SeniorityServiceTest
    {
        public static void Run()
        {
            var seniorityService = new SeniorityService();

            var employee1 = new Employee("Stanislaw Was", 4, 7000);
            var employee2 = new Employee("Zdzislaw Okon", 1, 4000);
            var employee3 = new Employee("Jaroslaw Milczarek", 15, 12000);
            var employee4 = new Employee("Katarzyna Nowak", 10, 9000);
            var employee5 = new Employee("Marek Koperek", 8, 9000);

            seniorityService.ClassifySeniorityBySalary(employee1);
            seniorityService.ClassifySeniorityBySalary(employee2);
            seniorityService.ClassifySeniorityBySalary(employee3);
            seniorityService.ClassifySeniorityBySalary(employee4);
            seniorityService.ClassifySeniorityBySalary(employee5);

            Console.WriteLine("Sklasyfikowani po zarobkach: ");
            Console.WriteLine("Juniors: ");
            PresentnEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentnEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentnEmployees(seniorityService.SeniorEmployees);

            seniorityService.ClearClassifyLists();
            seniorityService.ClassifySeniorityByExperience(employee1);
            seniorityService.ClassifySeniorityByExperience(employee2);
            seniorityService.ClassifySeniorityByExperience(employee3);
            seniorityService.ClassifySeniorityByExperience(employee4);
            seniorityService.ClassifySeniorityByExperience(employee5);

            Console.WriteLine("\n\nSklasyfikowani po doświadczeniu: ");
            Console.WriteLine("Juniors: ");
            PresentnEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentnEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentnEmployees(seniorityService.SeniorEmployees);
        }

        public static void PresentnEmployees(List<Employee> employees)
        {
            foreach(var employee in employees)
            {
                Console.WriteLine($"\tEmployee: {employee.Name}");
            }
        }
    }
}
