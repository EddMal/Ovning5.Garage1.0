using System.Drawing;
using static Garage1._0.VehicleProperties;
using static Garage1._0.VehicleSubclasses;
using static Garage1._0.VehicleSubclasses.Airplane;

namespace Garage1._0
{
    internal class GarageHandler//:VehicleProperties
    {
        private Garage<Vehicle> garage;

        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
            UI.PrintData($"New garage created with the capacaty of {capacity} slots.");
        }

        internal void Park(Vehicle v)
        {
            garage.Park(v);
        }

        internal void Remove(string registrationNumber)
        { 
            garage.Remove(registrationNumber);
        }

        internal List<Vehicle> GetAllGarageData()
        {

            List<Vehicle> vehicles = (List<Vehicle>)garage.GetEnumerator();
            return vehicles;
        }

        internal virtual Vehicle CreateVehicle(int action)
        {
            Vehicle createdVehicle;
            switch (action)
            {
                case 0:// "AIRPLANE":
                    createdVehicle = CreateAirplane();
                    break;
                case 1:// "BOAT":
                    createdVehicle = CreateBoat();
                    break;
                case 2:// "BUS":
                    createdVehicle = CreateBus();
                    break;
                case 3://"CAR":
                    createdVehicle = CreateCar();
                    break;
                case 4:// "MOTORCYCLE":
                    createdVehicle = CreateMotorcycle();
                    break;
                default:
                    throw new ArgumentException("Something went wrong when trying to create a vehicle, probably caused by the handling of input.");
                    //break;
            }
                    return createdVehicle;
        }

        public virtual Airplane CreateAirplane()
        {

            //VehicleProperties airplaneProperties = new VehicleProperties();
            //Validated validated = new Validated();

            //airplaneProperties.Type = "Airplane";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            //airplaneProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            //airplaneProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            //airplaneProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            //airplaneProperties.NumberOfSeats = Validated.SetInt("Enter the number of seats. Input Must be entered in numbers and be less than 25", (seats) => { return true ? seats <= 25 && seats >= 0 : false; });


            var Type = "Airplane";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            var Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            var RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            var NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            var NumberOfSeats = Validated.SetInt("Enter the number of seats. Input Must be entered in numbers and be less than 25", (seats) => { return true ? seats <= 25 && seats >= 0 : false; });

            object[] airplaneProperties = new object[] { Color, Type, RegistrationNumber, NumberOfWheels, NumberOfSeats };

            Airplane airplane = new Airplane(airplaneProperties);

            return airplane;
        }

        public virtual Boat CreateBoat()
        {

            //VehicleProperties boatProperties = new VehicleProperties();
            //boatProperties.Type = "Boat";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            //boatProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the airplane:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            //boatProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            //boatProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            //boatProperties.Decks = Validated.SetInt("Enter the number of decks. Input Must be entered in numbers and must be within range 0 to 2", (decks) => { return true ? decks < 0 && decks > 2 : false; });

            var Type = "Boat";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            var Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the airplane:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            var RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            var NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            var Decks = Validated.SetInt("Enter the number of decks. Input Must be entered in numbers and must be within range 0 to 2", (decks) => { return true ? decks < 0 && decks > 2 : false; });


            object[] boatProperties = new object[] { Color, Type, RegistrationNumber, NumberOfWheels, Decks };


            Boat boat = new Boat(boatProperties);

            return boat;
        }

        public virtual Bus CreateBus()
        {

           // VehicleProperties busProperties = new VehicleProperties();

            //busProperties.Type = "Bus";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            //busProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the bus:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            //busProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            //busProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            //busProperties.ElectricMotor = Validated.SetStringCaseInsesitive("The bus must have an electric motor:", (string s) => { return true ? s == "YES" || s == "NO" : false; });

            var Type = "Bus";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            var Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the bus:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            var RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            var NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            var ElectricMotor = Validated.SetStringCaseInsesitive("The bus must have an electric motor:", (string s) => { return true ? s == "YES" || s == "NO" : false; });


            object[] busProperties = new object[] { Color, Type, RegistrationNumber, NumberOfWheels, ElectricMotor };
            Bus bus = new Bus(busProperties);

            return bus;
        }

        public virtual Car CreateCar()
        {
            
           // new object[] carProperties = new VehicleProperties();

            var Type = "car";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            var Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            var RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            var NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            var CarBrand = Validated.SetStringCaseInsesitive("Valid brands are: \nVolvo,\nSaab,\nFiat,\nToyota,\nNissan,\nRenault\nFord,\nAudi\nVolkswagen,\nIf the brand is not represented enter other\nEnter the brand of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(CarBrands), value: s); });

            object[] carProperties = new object[] { Color, Type, RegistrationNumber, NumberOfWheels, CarBrand };
            Car car = new Car(carProperties);

            return car;
        }

        public virtual Motorcycle CreateMotorcycle()
        {

            //VehicleProperties motorcycleProperties = new VehicleProperties();

            var Type = "Motorcycle";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            var Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            var RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            var NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            var Roof = Validated.SetStringCaseInsesitive("The information about wheter the motorcycle has a roof is mandatory Enter yes or no:", (string s) => { return true ? s == "YES" || s == "NO" : false; });

            object[] motorcycleProperties = new object[] { Color, Type, RegistrationNumber, NumberOfWheels, Roof };


            Motorcycle motorcycle = new Motorcycle(motorcycleProperties);

            return motorcycle;
        }





    }
}