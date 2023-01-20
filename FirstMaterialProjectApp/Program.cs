using FirstMaterialProjectApp.Classes;
using FirstMaterialProjectApp.Enums;

var pierwszy = new Employees("Damian", "Malejka");
Console.WriteLine(pierwszy.EmployeeSalary());
pierwszy.ChangeContract(ContractTypes.FULLEMPLOYEECONTRACT);
Console.WriteLine(pierwszy.EmployeeSalary());
pierwszy.Contract.ChangeOvertime(10);
Console.WriteLine(pierwszy.EmployeeSalary());
var drugi = new Employees("testowy", "stazysta");
Console.WriteLine(drugi.EmployeeSalary());
drugi.Contract.ChangeBasicSalary(2000);
Console.WriteLine(drugi.EmployeeSalary());

Console.WriteLine(drugi.ToString());

