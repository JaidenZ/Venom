using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venom.Core.Machine
{
    using Venom.Core.Machine.Proxy;

    public partial class VenomConstruction : MachineBase
    {
        public override string MachineName { get; private set; }

        public override DateTime InitialTime => throw new NotImplementedException();

        public override void InitialMachine(string machineName)
        {
            this.MachineName = machineName;

        }

        internal override void CreatVenomBuiler(IVenom venom)
        {
            throw new NotImplementedException();
        }
    }
}
