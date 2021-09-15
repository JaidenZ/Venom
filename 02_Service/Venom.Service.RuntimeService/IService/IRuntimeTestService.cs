namespace Venom.Service.RuntimeService.IService
{
    using Venom.Entity.Runtime;
    using Venom.Core.Component.Aop.Service;
    using Venom.Service.RuntimeService.Filter;
    
    /// <summary>
    /// 
    /// </summary>
    [ServiceObject(ServiceName = "运行时测试服务" , ServiceFilter = typeof(RuntimeTestFilter))]
    public interface IRuntimeTestService : IServiceBase
    {

        /// <summary>
        /// 注册宿主
        /// </summary>
        /// <param name="entity"></param>
        string RegistVenomHost(VenomRuntimeEntity entity);


    }
}
