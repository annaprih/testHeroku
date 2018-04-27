using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace test
{
    public class Program
    {
        IConfigurationRoot conf;
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(new ConfigurationBuilder().AddCommandLine(args).Build())
                .UseStartup<Startup>()
                .Build();
    }
}
