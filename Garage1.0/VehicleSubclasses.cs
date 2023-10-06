﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal class VehicleSubclasses
    {
        public class UnknownVehicle : Vehicle//, IVehicle
        {
            public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels};
            public UnknownVehicle(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }
        }

        public class Airplane : Vehicle//, IVehicle
        {
            public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, NumberOfSeats };
            public Airplane(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }
        }

        public class Boat : Vehicle//, IVehicle
        {
            public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, Decks };
            public Boat(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }
        }

        public class Bus : Vehicle//, IVehicle
        {
            public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, ElectricMotor };
            public Bus(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }
        }

        public class Car : Vehicle//, IVehicle
        {
            public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, CarBrand };
            public Car(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {
                this.vehicleProperties = vehicleProperties; ;
            }

        }

        public class Motorcycle : Vehicle//, IVehicle
        {
            public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, Roof };
            public Motorcycle(VehicleProperties vehicleProperties) : base(vehicleProperties)
            {

            }

        }


    }
}
