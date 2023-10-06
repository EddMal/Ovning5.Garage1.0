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
        public class UnknownVehicle : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels};
            //public UnknownVehicle(object[] vehicleProperties) : base(vehicleProperties)
            //{
            //    this.vehicleProperties = vehicleProperties;
            //}
        }

        public class Airplane : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, NumberOfSeats };
            public override object[] GetVihecleProperties()
            { // Bad practise string input.
                object[] specifiedproperties = VehicleProperties.SpecifiedVihecleProperties("AIRPLANE");
                return specifiedproperties;
            }
            public Airplane(object[] vehicleProperties) : base(vehicleProperties)
            {

            }
        }

        public class Boat : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, Decks };

            public override object[] GetVihecleProperties()
            { // Bad practise string input.
                object[] specifiedproperties = VehicleProperties.SpecifiedVihecleProperties("BOAT");
                return specifiedproperties;
            }

            public Boat(object[] vehicleProperties) : base(vehicleProperties)
            {

            }
        }

        public class Bus : Vehicle//, IVehicle
        {
            // public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, ElectricMotor };

            public override object[] GetVihecleProperties()
            { // Bad practise string input.
                object[] specifiedproperties = VehicleProperties.SpecifiedVihecleProperties("BUS");
                return specifiedproperties;
            }

            public Bus(object[] vehicleProperties) : base(vehicleProperties)
            {

            }
        }

        public class Car : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, CarBrand };

            public override object[] GetVihecleProperties()
            { // Bad practise string input.
                object[] specifiedproperties = VehicleProperties.SpecifiedVihecleProperties("CAR");
                return specifiedproperties;
            }

            public Car(object[] vehicleProperties) : base(vehicleProperties)
            {
                this.vehicleProperties = vehicleProperties; ;
            }

        }

        public class Motorcycle : Vehicle//, IVehicle
        {
            //public override object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels, Roof };

            public override object[] GetVihecleProperties()
            { // Bad practise string input.
                object[] specifiedproperties = VehicleProperties.SpecifiedVihecleProperties("MOTORCYCLE");
                return specifiedproperties;
            }

            public Motorcycle(object[] vehicleProperties) : base(vehicleProperties)
            {

            }

        }


    }
}
