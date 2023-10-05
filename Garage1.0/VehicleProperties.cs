using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    // Test <T> and insert ex. a list with number of parameters for diffrent types and use as number for vehicleProperties.
    internal class VehicleProperties
    {
        private string color;
        private string type;
        private string registrationNumber;
        private int numberOfWheels;
        private int numberOfSeats;

        //private string AIRPLANE = "AIRPLANE";
        //private string BOAT = "BOAT";
        //private string BUS = "BUS";
        //private string CAR = "CAR";
        //private string MOTORCYCLE = "MOTORCYCLE";
        // private string[] types => new string[] { AIRPLANE, BOAT, BUS, CAR, MOTORCYCLE };
        public virtual object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels };

        public enum VehicleType 
        { 
            AIRPLANE,
            BOAT,
            BUS,
            CAR,
            MOTORCYCLE,
        }

        public enum VehicleColor
        {
            GREEN,
            RED,
            BLUE,
            YELLOW,
            BLACK,
            WHITE,
            GREY,
            BEIGE,
            OTHER,
        }

        public string Color
        {
            get { return color; }
            
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Color of vehicle cant be left empty");
                }
                color = value;
            }
        }
        public string Type
        {
            get => type;
            set
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

            set
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
            set
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
            set
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
