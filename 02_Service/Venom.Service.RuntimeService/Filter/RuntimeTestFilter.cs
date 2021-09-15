namespace Venom.Service.RuntimeService.Filter
{
    using System;
    using System.Reflection;
    using Venom.Core.Component.Aop.Service;
    using Venom.Service.RuntimeService.IService;

    public class RuntimeTestFilter : ServiceFilter
    {
        public RuntimeTestFilter(IServiceBase service) : base(service)
        {
        }

        protected override object InvokeMember(IServiceBase service, MethodBase method, params object[] args)
        {
            try
            {
                return method.Invoke(service, args);
            }
            catch (TargetInvocationException e)
            {
                Exception exception = e.InnerException;
            }
            return null;
        }
    }
}
