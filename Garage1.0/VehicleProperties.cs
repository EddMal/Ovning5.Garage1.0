using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal class VehicleProperties : IVehicleProperties
    {
        private string color;
        private string type;
        private string registrationNumber;
        private int numberOfWheels;
        private int numberOfSeats;
        public virtual object[] vehicleProperties => new object[] { color, type, registrationNumber, numberOfWheels };

        public string Color
        {
            get { return color; }
            // Protected only sub-classes can set;
            protected set
            {

            }
        }
        public string Type
        {
            get => type;
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Type of vehicle cant be left empty");
                }
                type = value;
            }
        }

        public string RegistrationNumber
        {
            get => registrationNumber;

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Registration number cant be left empty");
                }

                registrationNumber = value;
            }
        }

        public int NumberOfWheels
        {
            get => numberOfWheels;
            protected set
            {
                if (value <= 50 && value >= 0)
                {
                    throw new IndexOutOfRangeException("Number of wheels must be within range 0 to 50");
                }
                numberOfWheels = value;
            }
        }

        public int NumberOfSeats
        {
            get => numberOfSeats;
            protected set
            {
                if (value <= 50 && value >= 0)
                {
                    throw new IndexOutOfRangeException("Number of seats must be within range 1 to 10");
                }
                numberOfSeats = value;
            }
        }
    }
}
