// See https://aka.ms/new-console-template for more information

using EFCoreAIGS.Data.Service;
using EFCoreAIGS.erp.Entites;
using EFCoreAIGS.erp.Service;
using EFCoreAIGS.UI;



//new ExecuteLogic().Execute();
// await new ExecuteLogic().ExecuteAsync();
// new ExecuteLogicDBRelationship().ExecuteLogic();

//var use = new User {Username = "Core", Password = "123456"};

// var auth = new AuthenticateService();
//auth.Register(use);
// auth.Login(use);

// Console.WriteLine($"Current User Login :: {auth.CurrentUserLogin}");


//=========== BASE TESTING ==============

var emp = new EmployeeService();
emp.disPlayName();

foreach (var employee in emp.GetAll())
{
    Console.WriteLine($"emp : {employee.FirstName}");
}
