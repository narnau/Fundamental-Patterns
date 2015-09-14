using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Patterns.Chain_of_Responsability
{
    public class MainProgramCR
    {
        public VehicleCapacity BusCapacity;
        public VehicleCapacity CarCapacity;
        public VehicleCapacity BikeCapacity;

        public MainProgramCR()
        {
            this.BikeCapacity = new BikeCapacity(1);
            this.CarCapacity = new CarCapacity(5);
            this.BusCapacity = new BusCapacity(40);

            BikeCapacity.SetSuccessor(CarCapacity);
            CarCapacity.SetSuccessor(BusCapacity);
        }

        public void Run()
        {
            Console.WriteLine("Chain of Responsability pattern");
            Console.WriteLine();

            this.BikeCapacity.ProcessRequest(5);
            this.BikeCapacity.ProcessRequest(1);
            this.BikeCapacity.ProcessRequest(6);

            Console.WriteLine();
        }
    }
}
