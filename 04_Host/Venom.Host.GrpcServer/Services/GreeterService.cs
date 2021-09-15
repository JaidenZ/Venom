using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Venom.Core.Component.Aop.Service;
using Venom.Service.RuntimeService.IService;

namespace Venom.Host.GrpcServer
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {

            //string message = ServiceObjectContainer.Get<IRuntimeTestService>().RegistVenomHost(new Entity.Runtime.VenomRuntimeEntity()
            // {
            //     HostName = context.Host,
            //     HostDeviceName = request.Name
            // });


            return Task.FromResult(new HelloReply
            {
                Message = request.Name + context.Host
            });
        }
    }
}
