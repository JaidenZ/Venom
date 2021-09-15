using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Venom.Core.Component.Aop.Service;

namespace Venom.Host.GrpcServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreatIocServiceContainer();
            CreateHostBuilder(args).Build().Run();
        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void CreatIocServiceContainer()
        {
            Assembly serviceAssembly = Assembly.Load("Venom.Service.RuntimeService");
            ServiceObjectContainer.Load(serviceAssembly);
        }
    }
}
