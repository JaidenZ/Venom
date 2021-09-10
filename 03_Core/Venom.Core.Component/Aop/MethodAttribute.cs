using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venom.Core.Component.Aop
{

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class,AllowMultiple = false,Inherited = true)]
    public class MethodAttribute : Attribute
    {



    }
}
