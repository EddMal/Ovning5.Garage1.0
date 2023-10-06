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

            VehicleProperties airplaneProperties = new VehicleProperties();
            //Validated validated = new Validated();
            airplaneProperties.Type = "Airplane";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            airplaneProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            airplaneProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            airplaneProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            airplaneProperties.NumberOfSeats = Validated.SetInt("Enter the number of seats. Input Must be entered in numbers and be less than 25", (seats) => { return true ? seats <= 25 && seats >= 0 : false; });
            Airplane airplane = new Airplane(airplaneProperties);

            return airplane;
        }

        public virtual Boat CreateBoat()
        {

            VehicleProperties boatProperties = new VehicleProperties();
            boatProperties.Type = "Boat";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            boatProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the airplane:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            boatProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            boatProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            boatProperties.Decks = Validated.SetInt("Enter the number of decks. Input Must be entered in numbers and must be within range 0 to 2", (decks) => { return true ? decks < 0 && decks > 2 : false; });
           
            Boat boat = new Boat(boatProperties);

            return boat;
        }

        public virtual Bus CreateBus()
        {

            VehicleProperties busProperties = new VehicleProperties();

            busProperties.Type = "Bus";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            busProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the bus:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            busProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            busProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            busProperties.ElectricMotor = Validated.SetStringCaseInsesitive("The bus must have an electric motor:", (string s) => { return true ? s == "YES" || s == "NO" : false; });
           
            Bus bus = new Bus(busProperties);

            return bus;
        }

        public virtual Car CreateCar()
        {
            
            VehicleProperties carProperties = new VehicleProperties();

            carProperties.Type = "car";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            carProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            carProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            carProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            carProperties.CarBrand = Validated.SetStringCaseInsesitive("Valid brands are: \nVolvo,\nSaab,\nFiat,\nToyota,\nNissan,\nRenault\nFord,\nAudi\nVolkswagen,\nIf the brand is not represented enter other\nEnter the brand of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(CarBrands), value: s); });
           
            Car car = new Car(carProperties);

            return car;
        }

        public virtual Motorcycle CreateMotorcycle()
        {

            VehicleProperties motorcycleProperties = new VehicleProperties();

            motorcycleProperties.Type = "Motorcycle";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            motorcycleProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            motorcycleProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            motorcycleProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            motorcycleProperties.Roof = Validated.SetStringCaseInsesitive("The information about wheter the motorcycle has a roof is mandatory Enter yes or no:", (string s) => { return true ? s == "YES" || s == "NO" : false; });

            Motorcycle motorcycle = new Motorcycle(motorcycleProperties);

            return motorcycle;
        }





    }
}