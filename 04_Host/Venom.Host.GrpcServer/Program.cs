namespace Venom.Host.GrpcServer
{
    using System.Reflection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.AspNetCore.Hosting;    
    using Venom.Core.Component.Aop.Service;


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

        protected static void CreatIocServiceContainer()
        {
            Assembly serviceAssembly = Assembly.Load("Venom.Service.RuntimeService");
            ServiceObjectContainer.Load(serviceAssembly);

        }
    }
}
