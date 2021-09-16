namespace Venom.Service.RuntimeService.IService
{
    using Venom.Entity.Runtime;
    using Venom.Core.Component.Aop.Service;
    
    /// <summary>
    /// 运行时服务
    /// </summary>
    public interface IRuntimeService : IServiceBase
    {

        /// <summary>
        /// 注册宿主
        /// </summary>
        /// <param name="entity"></param>
        string RegistVenomHost(VenomRuntimeEntity entity);


    }
}
