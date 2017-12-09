using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ddf
{
    public class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        static String _sslPassword = null;
        
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<Startup>();
            
            Configuration = builder.Build();
            
            _sslPassword = Configuration["SslPassword"];

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) => 
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseKestrel(options =>
                    {                            
                        options.Listen(IPAddress.Parse("127.0.0.1"), 5001, listenOptions =>
                                {
                                    listenOptions.UseHttps("ssl.pfx", _sslPassword);
                                });
                    })
            .Build();
    }
}
