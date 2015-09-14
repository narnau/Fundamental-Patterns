using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Chain_of_Responsability
{
    public abstract class VehicleCapacity
    {

        public int MaxCapacity { get; set; }
        public VehicleCapacity Successor { get; set; }

        public VehicleCapacity(int maxCapacity)
        {
            this.MaxCapacity = maxCapacity;
        }

        public void SetSuccessor(VehicleCapacity successor)
        {
            this.Successor = successor;
        }

        public abstract void ProcessRequest(int MaxCapacity);
    }
}
