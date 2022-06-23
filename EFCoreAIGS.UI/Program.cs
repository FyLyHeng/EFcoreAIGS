using System.ComponentModel;
using System.Runtime.InteropServices;
using EFCore.AIGS.SQLITE.Entity;
using EFCore.AIGS.SQLITE.Service;
using EFCore.AIGS.UUID;
using EFCoreAIGS.Data.Service;

Console.WriteLine($"{RuntimeInformation.IsOSPlatform(OSPlatform.OSX)} -- Hello Mac");

/*new ExecuteLogic().Execute();
 await new ExecuteLogic().ExecuteAsync();
 new ExecuteLogicDBRelationship().ExecuteLogic();

var use = new User {Username = "Core", Password = "123456"};

 var auth = new AuthenticateService();
auth.Register(use);
 auth.Login(use);

 Console.WriteLine($"Current User Login :: {auth.CurrentUserLogin}");
=========== BASE TESTING ==============
 var a = AppConfiguration.ConnectionString;

 var emp = new EmployeeService();
 emp.disPlayName();

 foreach (var employee in emp.GetAll())
 {
     Console.WriteLine($"emp : {employee.FirstName}");
 }*/

// UUID TESTING
/*var itemService = new ItemService();

itemService.Add();

foreach (var item in itemService.All())
{
    Console.WriteLine($"Full info {item.Name} - {item.ItemGroupId}  {item.ItemGroup.Id}");
}*/

//SQLite

var service = new ItemService();
service.Add();

