using Microsoft.Extensions.Configuration;

namespace EFCoreAIGS.Data.Configuration.AppConfig
{
    public static class AppConfiguration
    {
        public readonly static string? ConnectionString;

         static AppConfiguration()
         {
             Console.WriteLine("does it work or not");
             
             // string solutionPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName);
             // string fileConfigName = "/appsettings.json";
             //
             // IConfigurationRoot configuration = new ConfigurationBuilder()
             //     .SetBasePath(Directory.GetCurrentDirectory())
             //     .AddJsonFile($"{fileConfigName}",optional:false)
             //     .Build();
             // ConnectionString = configuration.GetConnectionString("DataConnection")!;
             
             var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("Configuration/appsettings.json", optional: false);

             IConfiguration config = builder.Build();
             ConnectionString = config.GetConnectionString("DataConnection");
             //ConnectionString = config.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
         }
        
        /*private static AppConfiguration _instance ;
        private static readonly object instanceLock = new object();
        private static IConfigurationRoot _configuration;
        
        private AppConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true,
                    reloadOnChange: true);
            _configuration = builder.Build();
        }
        
        public static AppConfiguration Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new AppConfiguration();
                    }
                    return _instance;
                }
            }
        }
        public static IConfigurationRoot ConfigurationRoot
        {
            get
            {
                if (_configuration == null) { var x = Instance; }
                return _configuration;
            }
        }*/

        public static String getPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
