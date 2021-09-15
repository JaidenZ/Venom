namespace Venom.Service.RuntimeService.Constract
{
    using System;
    using Venom.Entity.Runtime;
    using Venom.Service.RuntimeService.IService;


    public class RuntimeTestService : IRuntimeTestService
    {
        public string RegistVenomHost(VenomRuntimeEntity entity)
        {
            entity.SerialCode = $"{DateTime.Now.Ticks.ToString()}";
            return $"设备:{entity.HostDeviceName}进行注册:{entity.HostName}的注册码:{entity.SerialCode}";
            
        }
    }
}
