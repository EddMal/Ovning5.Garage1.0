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
        private string carBrand;
        private string electricMotor;
        private string roof;
        private int numberOfWheels;
        private int numberOfSeats;
        private int decks;


        //private string AIRPLANE = "AIRPLANE";
        //private string BOAT = "BOAT";
        //private string BUS = "BUS";
        //private string CAR = "CAR";
        //private string MOTORCYCLE = "MOTORCYCLE";
        // private string[] types => new string[] { AIRPLANE, BOAT, BUS, CAR, MOTORCYCLE };

        //The handling of this object generates a lot of objects ask and investigate.
        //public virtual object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels }
        internal  object[] vehicleProperties_;// => new object[] { Color, Type, RegistrationNumber, NumberOfWheels }
        public virtual object[] vehicleProperties
        {
            get
            {
                return vehicleProperties_;
            }

            set
            {
                vehicleProperties_ = value;
            }
        }


        //public virtual object[] subVehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels };


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

        public enum CarBrands
        {
            VOLVO,
            SAAB,
            FIAT,
            TOYOTA,
            NISSAN,
            RENAULT,
            FORD,
            AUDI,
            VOLKSWAGEN,
            OTHER,
        }

        public string Roof
        {
            get { return roof; }

            set
            {
                if (value != "YES" && value != "YES")
                {
                    throw new ArgumentNullException("Color of vehicle cant be left empty");
                }
                roof = value;
            }
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

        public string ElectricMotor
        {
            get => electricMotor;

            set
            {
                if (value != "YES")
                {
                    throw new ArgumentNullException("There must me an electric motor on the vehicle.");
                }

                electricMotor = value;
            }
        }

        public string CarBrand
        {
            get { return carBrand; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Brand of vehicle cant be left empty");
                }
                carBrand = value;
            }
        }
        public int NumberOfWheels
        {
            get => numberOfWheels;
            set
            {
                if (value < 0 && value > 50)
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
                if (value < 0 && value > 25)
                {
                    throw new IndexOutOfRangeException("Number of seats must be within range 0 to 25");
                }
                numberOfSeats = value;
            }
        }

        public int Decks
        {
            get => decks;
            set
            {
                if (value < 0 && value > 2)
                {
                    throw new IndexOutOfRangeException("Number of decks must be within range 0 to 2");
                }
                decks = value;
            }
        }
    }
}
