namespace Venom.Core.Component.Aop.Proxy
{
    public interface InvocationHandler
    {
        object InvokeMember(object obj, int rid, string name, params object[] args);
    }
}
