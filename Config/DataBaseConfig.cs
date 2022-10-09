using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Config
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
