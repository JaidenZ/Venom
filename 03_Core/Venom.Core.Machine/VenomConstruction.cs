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

        private string _machineName;
        private DateTime _initTime;

        public override string MachineName { get { return _machineName; } }

        public override DateTime InitialTime { get { return _initTime; } }

        public override void InitialMachine(string machineName)
        {
            this._machineName = machineName;
            this._initTime = DateTime.Now;
        }

        internal override void CreatVenomBuiler(IVenom venom)
        {
            throw new NotImplementedException();
        }
    }
}
