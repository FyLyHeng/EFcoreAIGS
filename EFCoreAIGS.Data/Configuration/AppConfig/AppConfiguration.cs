using Microsoft.Extensions.Configuration;

namespace EFCoreAIGS.Data.Configuration.AppConfig
{
    public class AppConfiguration
    {
        public readonly static string ConnectionString;

        static AppConfiguration()
        {
            Console.WriteLine("does it work or not");
            string solutionPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.Parent!.FullName);
            string projectNameSpace = "EFCoreAIGS.Data";
            string fileConfigName = "appsettings.json";

            Console.WriteLine($"{projectNameSpace}");

            Console.WriteLine($"{solutionPath}/{projectNameSpace}/{fileConfigName}");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"{solutionPath}/{projectNameSpace}/{fileConfigName}",optional:true)
                .Build();
            
            ConnectionString = configuration.GetConnectionString("url")!;
        }
    }
}
