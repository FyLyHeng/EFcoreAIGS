using System.Runtime.InteropServices;
using EFCore.AIGS.Infrastructure;
using EFCoreAIGS.Data.Service;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine($"{RuntimeInformation.IsOSPlatform(OSPlatform.OSX)} -- Hello Mac");



//Create class for group all the register service at backend-class library
var serviceProvider = new ServiceCollection()
 .AddLogging()
 .AddSingleton<IEmployeeService, EmployeeService>()
 .BuildServiceProvider();




SyncData.Do1();
SyncData.Do();



//var bar = serviceProvider.GetService<IEmployeeService>();



 //Console.WriteLine($"Here is DI Pro {bar.Display()}");




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

// var service = new ItemService();
// service.Add();

