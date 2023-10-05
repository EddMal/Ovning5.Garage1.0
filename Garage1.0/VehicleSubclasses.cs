using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal class VehicleSubclasses
    {

        public class Airplane : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, NumberOfSeats };
            public Airplane(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }
        }

        public class Boat : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, NumberOfSeats };
            public Boat(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }
        }

        public class Bus : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, NumberOfSeats };
            public Bus(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }
        }

        public class Car : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, NumberOfSeats };
            public Car(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }

        }

        public class Motorcycle : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, NumberOfSeats };
            public Motorcycle(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }

        }


    }
}
