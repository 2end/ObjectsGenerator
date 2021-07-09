using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using ObjectsGenerator.Contracts;
using ObjectsGenerator.Generators;
using ObjectsGenerator.Models.Settings;
using System;
using System.IO;

namespace ObjectsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            Console.WriteLine("Start...");
            serviceProvider.GetService<App>().Run();
            Console.WriteLine("End...");
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var appSettingsJson = File.ReadAllText("appsettings.json");
            var settings = JsonConvert.DeserializeObject<AppSettings>(appSettingsJson);
            services.AddSingleton(settings);

            services.AddSingleton<App>();
            services.AddSingleton<IObjectRequestGenerator, ObjectRequestGenerator>();
        }
    }
}
