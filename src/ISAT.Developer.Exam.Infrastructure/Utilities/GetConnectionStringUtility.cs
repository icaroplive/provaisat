using Microsoft.Extensions.Configuration;
using System.IO;

namespace ISAT.Developer.Exam.Infrastructure.Utilities
{
    public static class GetConnectionStringUtility
    {
        public static string GetConnectionString(string connectionStringName)
        {
            string path = GetPathAppsettings();

            IConfigurationRoot config = new ConfigurationBuilder().SetBasePath(path).AddJsonFile("appsettings.json").Build();

            return config.GetConnectionString(connectionStringName);
        }

        public static string GetConnectionString(string connectionStringName, string environment)
        {
            string path = GetPathAppsettings();

            environment = !string.IsNullOrEmpty(environment) ? "." + environment : "";

            IConfigurationRoot config = new ConfigurationBuilder().SetBasePath(path).AddJsonFile($"appsettings{environment}.json").Build();

            return config.GetConnectionString(connectionStringName);
        }

        private static string GetPathAppsettings()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "../ISAT.Developer.Exam.Web");

            if (!Directory.Exists(path))
                path = Path.Combine(Directory.GetCurrentDirectory(), "../../../../ISAT.Developer.Exam.Web");

            if (!Directory.Exists(path))
                path = Directory.GetCurrentDirectory();

            return path;
        }
    }
}