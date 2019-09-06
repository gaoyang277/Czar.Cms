using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Sample01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //IWebHost对象运行我们的Web应用程序，启动一个一直运行监听http请求的任务
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            // ;
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
            var env = hostingContext.HostingEnvironment;
            config.AddJsonFile("appsetting.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.josn", optional: true, reloadOnChange: true)
            .AddJsonFile("Content.json", optional: false, reloadOnChange: false).AddEnvironmentVariables();
            })
            .UseStartup<Startup>();

           
            }
}
