using Microsoft.Extensions.Configuration;

namespace EFCoreAIGS.Data.Configuration.AppConfig
{
    public class AppConfiguration
    {
        public readonly static string ConnectionString;

        static AppConfiguration()
        {
            Console.WriteLine("does it work or not");
            string solutionPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory)!.Parent!.FullName);
            string projectNameSpace = "EFCoreAIGS.Data";
            string fileConfigName = "appsettings.json";
            

            
            //var path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"));
            // var path =  Path.Combine(AppDomain.CurrentDomain.DynamicDirectory);
            //string s_commonAppData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            
            string filename = @"appsettings.json";
            string filePath= Path.GetFullPath(filename) ;


            Console.WriteLine($"[{filePath}]");

            Console.WriteLine($"{solutionPath}/{projectNameSpace}/{fileConfigName}");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"{filePath}",optional:true)
                //.AddJsonFile($"{solutionPath}/{projectNameSpace}/{fileConfigName}",optional:true)
                .Build();
            
            ConnectionString = configuration.GetConnectionString("url")!;
        }
    }
}
