using System.IO;
using Microsoft.Extensions.Configuration;

namespace POngBaratox2._0.Config
{
    public class DataBaseConfig
    {

        public static IConfigurationRoot Config { get; set; }

        public static string Get()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);

            Config = builder.Build();
            return Config["ConnectionStrings:DefaultConnection"];

        }
    }
}
