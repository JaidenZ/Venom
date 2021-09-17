using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venom.Core.Machine.Proxy
{
    internal interface IVenom:IMachineBase
    {
        /// <summary>
        /// 修正思维
        /// </summary>
        /// <param name="mind"></param>
        abstract void CorrectionMind(IMind mind);

        /// <summary>
        /// 执行行为
        /// </summary>
        abstract void ExecuteBehavior(IBehavior behavior);




    }
}
