using ADODemoConsoleApp;

var connectionString = "Data Source=DAMIAN-KOMPUTER\\SQLEXPRESS01;Initial Catalog=company;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; //pobieramy z property bazy w sql explorer w view

ADODemo demo = new ADODemo(connectionString);
demo.RunSelectAllFromEmployees();
demo.RunSelectDefinedColumnSet("first_name", "email");
demo.InsertEmployeeDemo();
demo.InsertManyEmployeesDemo();
