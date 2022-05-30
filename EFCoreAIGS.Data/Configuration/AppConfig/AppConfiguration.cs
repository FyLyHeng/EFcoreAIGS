using Microsoft.Extensions.Configuration;

namespace EFCoreAIGS.Data.Configuration.AppConfig
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            Console.WriteLine($"Root : {Directory.GetCurrentDirectory()}");
            
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            
            
            Console.WriteLine($"Qpath: {Directory.GetDirectoryRoot(Directory.GetCurrentDirectory())}");
            Console.WriteLine($"path: {path}");


            var root = configurationBuilder.Build();
            ConnectionString = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
        }
        
        
        // public AppConfiguration()
        // {
        //     var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);
        //
        //     IConfiguration config = builder.Build();
        //
        //     ConnectionString = config.GetValue<string>("ConnectionStrings:DataConnection");
        // }
        public string? ConnectionString { get; }
    }
}
