// See https://aka.ms/new-console-template for more information

using EFCoreAIGS.erp.Entites;
using EFCoreAIGS.erp.Service;
using EFCoreAIGS.UI;


// for datatime from C# to postgress we need to configure this below because it different format 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);


Console.WriteLine("Hello, World!"); 
new ExecuteLogic().Execute();
// await new ExecuteLogic().ExecuteAsync();
// new ExecuteLogicDBRelationship().ExecuteLogic();

var use = new User {Username = "Core", Password = "123456"};

// var auth = new AuthenticateService();
//auth.Register(use);
// auth.Login(use);

// Console.WriteLine($"Current User Login :: {auth.CurrentUserLogin}");
