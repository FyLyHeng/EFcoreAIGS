// See https://aka.ms/new-console-template for more information

using EFCoreAIGS.UI;


// for datatime from C# to postgress we need to configure this below because it different format 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

Console.WriteLine("Hello, World!");
//new ExecuteLogic().Execute();
new ExecuteLogic().ExecuteAsync();

// new ExecuteLogicDBRelationship().ExecuteLogic();