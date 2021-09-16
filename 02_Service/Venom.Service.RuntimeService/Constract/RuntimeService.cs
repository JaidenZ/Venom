namespace Venom.Service.RuntimeService.Constract
{
    using System;
    using Venom.Entity.Runtime;
    using Venom.Service.RuntimeService.IService;


    /// <summary>
    /// 运行时服务实现
    /// </summary>
    public class RuntimeService : IRuntimeService
    {
        /// <summary>
        /// 注册宿主主机
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string RegistVenomHost(VenomRuntimeEntity entity)
        {


            string guid = Guid.NewGuid().ToString();

            return guid;
            
        }
    }
}
