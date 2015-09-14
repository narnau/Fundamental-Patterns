using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Chain_of_Responsability
{
    public class CarCapacity : VehicleCapacity
    {
        public CarCapacity(int maxCapacity) : base(maxCapacity)
        {
        }

        public override void ProcessRequest(int maxCapacity)
        {
            if (maxCapacity <= this.MaxCapacity)
            {
                Console.WriteLine("Car max capacity is >= {0}", maxCapacity);
            }
            else
            {
                this.Successor.ProcessRequest(maxCapacity);
            }
        }
    }
}
