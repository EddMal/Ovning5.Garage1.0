using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Garage1._0.VehicleProperties;
using static Garage1._0.VehicleSubclasses;

namespace Garage1._0
{
    // Test <T> and insert ex. a list with number of parameters for diffrent types and use as number for vehicleProperties.
    internal class VehicleProperties
    {
        protected string color;
        protected string type;
        protected string registrationNumber;
        protected string carBrand;
        protected string electricMotor;
        protected string roof;
        protected int numberOfWheels;
        protected int numberOfSeats;
        protected int decks;


        //private string AIRPLANE = "AIRPLANE";
        //private string BOAT = "BOAT";
        //private string BUS = "BUS";
        //private string CAR = "CAR";
        //private string MOTORCYCLE = "MOTORCYCLE";
        // private string[] types => new string[] { AIRPLANE, BOAT, BUS, CAR, MOTORCYCLE };

        //The handling of this object generates a lot of objects ask and investigate.
        //public virtual object[] vehicleProperties => new object[] { Color, Type, RegistrationNumber, NumberOfWheels }
        //better word use characteristics:
        internal object[] vehicleProperties_;// => new object[] { Color, Type, RegistrationNumber, NumberOfWheels }
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
            AIRPLANE = 0,
            BOAT = 1,
            BUS = 2,
            CAR = 3,
            MOTORCYCLE = 4,
            UNDEFINEDVEHICLE = 5,
        }

        public enum VehiclesProperties
        {
            TYPE,
            COLOR,
            REGISTRATIONNUMBER,
            NUMBEROFWHEELS,
            NUMBEROFSEATS,
            DECKS,
            CARBRAND,
            ROOF,
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

        internal string Roof
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
        internal string Color
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
        internal string Type
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

        internal string RegistrationNumber
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

        internal string ElectricMotor
        {
            get => electricMotor;

            set
            {
                if (value != "YES" || value != "NO")
                {
                    throw new ArgumentNullException("Information about electric motor on the vehicle is obligatory.");
                }

                electricMotor = value;
            }
        }

        internal string CarBrand
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
        internal int NumberOfWheels
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

        internal int NumberOfSeats
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

        internal int Decks
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

        public static object[] SpecifiedVihecleProperties(string vehicleType)
        {
            
            VehicleProperties vehicle = new VehicleProperties();
            if (Enum.IsDefined(enumType: typeof(VehicleType), value: vehicleType))
            { vehicleType = vehicleType.ToUpper();
                //Bad practise hard coded values.
                switch (vehicleType)
                {
                    case "AIRPLANE":
                        vehicle.vehicleProperties = new object[] { vehicle.Color, vehicle.Type = vehicleType, vehicle.RegistrationNumber, vehicle.NumberOfWheels, vehicle.NumberOfSeats };
                        break;
                    case "BUSS":
                        vehicle.vehicleProperties = new object[] { vehicle.Color, vehicle.Type = vehicleType, vehicle.RegistrationNumber, vehicle.NumberOfWheels, vehicle.ElectricMotor };
                        break;
                    case "BOAT":
                        vehicle.vehicleProperties = new object[] { vehicle.Color, vehicle.Type = vehicleType, vehicle.RegistrationNumber, vehicle.NumberOfWheels, vehicle.Decks };
                        break;
                    case "CAR":
                        vehicle.vehicleProperties = new object[] { vehicle.Color, vehicle.Type = vehicleType, vehicle.RegistrationNumber, vehicle.NumberOfWheels, vehicle.CarBrand };
                        break;
                    case "MOTORCYCLE":
                        vehicle.vehicleProperties = new object[] { vehicle.Color, vehicle.Type = vehicleType, vehicle.RegistrationNumber, vehicle.NumberOfWheels, vehicle.Roof };
                        break;
                    default:
                        vehicle.vehicleProperties = new object[] { vehicle.Color, vehicle.Type = vehicleType, vehicle.RegistrationNumber, vehicle.NumberOfWheels };
                        break;             
                }
            }
            return vehicle.vehicleProperties;

        }

    }
}
