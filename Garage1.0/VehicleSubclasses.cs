using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal class VehicleSubclasses
    {
        

        public class Car : VehicleProperties, IVehicle
        {
            
            VehicleProperties IVehicle.VehicleAttribute { get; set; }

            public Car() { }:Base;
        }
    }
}
