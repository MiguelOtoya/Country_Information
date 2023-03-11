using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Country_Information
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseUrls("http://www.countries.com:5001")
            .Build();
    }
}
