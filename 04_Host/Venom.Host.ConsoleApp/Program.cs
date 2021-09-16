namespace Venom.Host.ConsoleApp
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Grpc.Net.Client;
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                var reply = await client.SayHelloAsync(new HelloRequest { Name = "VenomHost.ConsoleApp" + i });

                Console.WriteLine("Finish: " + reply.Message);
                Console.WriteLine("---------------------------------");
            }
            stopwatch.Stop();
            Console.WriteLine("Toaltal use:" + stopwatch.ElapsedMilliseconds + "ms");

            Console.WriteLine("Press any key to exit...");

            Console.ReadKey(false);
        }
    }
}
