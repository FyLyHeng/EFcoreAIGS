using Microsoft.Extensions.Configuration;

namespace EFCore.AIGS.UUID
{
    public static class AppConfiguration
    {
        public readonly static string? ConnectionString;

         static AppConfiguration()
         {
             var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("Configuration/appsettings.json", optional: false);

             IConfiguration config = builder.Build();
             ConnectionString = config.GetConnectionString("DataConnectionUUID");
         }
    }
}
