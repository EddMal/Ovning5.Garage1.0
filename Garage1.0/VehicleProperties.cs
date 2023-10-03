using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal class VehicleAttribute
    {
        private string color;
        private string type;
        private string registrationNumber;
        private int numberOfWheels;
        public virtual object[] vehicleAttribute => new object[] { color, type, registrationNumber, numberOfWheels };

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
                if (value < 50)
                {
                    throw new IndexOutOfRangeException("Number of wheels exceeds the number of wheels for vehicles");
                }
                numberOfWheels = value;
            }
        }
    }
}
