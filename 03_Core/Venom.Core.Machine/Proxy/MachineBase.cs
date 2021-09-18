namespace Venom.Core.Machine.Proxy
{
    using System;

    public abstract class MachineBase : IMachineBase
    {
        public abstract string MachineName { get; }
        public abstract DateTime InitialTime { get;}
        public abstract void InitialMachine(string machineName);
        internal abstract void CreatVenomBuiler(IVenom venom);
    }
}
