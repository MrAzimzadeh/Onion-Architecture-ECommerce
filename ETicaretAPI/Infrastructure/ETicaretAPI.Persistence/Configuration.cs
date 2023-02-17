using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ETicaretAPI.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();//bunun sayesinde json dosyalari 
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../presentation/ETicaretAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("MSSQL");
            }
        }
    }
}
