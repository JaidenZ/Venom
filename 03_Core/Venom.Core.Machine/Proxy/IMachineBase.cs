namespace Venom.Core.Machine.Proxy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;


    internal interface IMachineBase
    {
        string MachineName { get; }

        DateTime InitialTime { get; }

        abstract void InitialMachine(string machineName);
    }


    internal interface IMind
    {

        string MindName { get; set; }

        Action<object> PreviousStep { get; set; }

        Action<object> NextStep { get; set; }

        IMind GetMind(string mindName);

    }

    internal interface IBehavior
    {
        string BehaviorName { get; set; }

        int BehaviorType {  get; set; }

        int BehaviorState { get; set; }



    }

}
