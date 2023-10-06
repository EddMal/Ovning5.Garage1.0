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

            VehicleProperties vehicleProperties = new VehicleProperties();
            //Validated validated = new Validated();
            vehicleProperties.Type = "Airplane";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            vehicleProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            vehicleProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            vehicleProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            vehicleProperties.NumberOfSeats = Validated.SetInt("Enter the number of seats. Input Must be entered in numbers and be less than 25", (seats) => { return true ? seats <= 25 && seats >= 0 : false; });
            Airplane airplane = new Airplane(vehicleProperties);

            return airplane;
        }

        public virtual Boat CreateBoat()
        {

            VehicleProperties vehicleProperties = new VehicleProperties();
            vehicleProperties.Type = "Boat";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            vehicleProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the airplane:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            vehicleProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            vehicleProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            vehicleProperties.Decks = Validated.SetInt("Enter the number of decks. Input Must be entered in numbers and must be within range 0 to 2", (decks) => { return true ? decks < 0 && decks > 2 : false; });
           
            Boat boat = new Boat(vehicleProperties);

            return boat;
        }

        public virtual Bus CreateBus()
        {

            VehicleProperties vehicleProperties = new VehicleProperties();
            
            vehicleProperties.Type = "Bus";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            vehicleProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the bus:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            vehicleProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            vehicleProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            vehicleProperties.ElectricMotor = Validated.SetStringCaseInsesitive("The bus must have an electric motor:", (string s) => { return true ? s == "YES" || s == "NO" : false; });
           
            Bus bus = new Bus(vehicleProperties);

            return bus;
        }

        public virtual Car CreateCar()
        {
            
            VehicleProperties vehicleProperties = new VehicleProperties();
            
            vehicleProperties.Type = "car";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            vehicleProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            vehicleProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            vehicleProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            vehicleProperties.CarBrand = Validated.SetStringCaseInsesitive("Valid brands are: \nVolvo,\nSaab,\nFiat,\nToyota,\nNissan,\nRenault\nFord,\nAudi\nVolkswagen,\nIf the brand is not represented enter other\nEnter the brand of the car:", (string s) => { return Enum.IsDefined(enumType: typeof(CarBrands), value: s); });
           
            Car car = new Car(vehicleProperties);

            return car;
        }

        public virtual Motorcycle CreateMotorcycle()
        {

            VehicleProperties vehicleProperties = new VehicleProperties();

            vehicleProperties.Type = "Motorcycle";// Note to self why does this not work to set property? Validated.SetString(Vehicleproperties.Type, "Enter the type of the vehicle, Car, Boat etcetera:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleType), value: s); });
            vehicleProperties.Color = Validated.SetStringCaseInsesitive("Valid colors are Green,\nRed,\nBlue,\nYellow,\nBlack,\nWhite,\nGrey,\nBeige,\nOther.\nEnter the color of the:", (string s) => { return Enum.IsDefined(enumType: typeof(VehicleColor), value: s); });
            vehicleProperties.RegistrationNumber = Validated.SetString("Valid length for registration number is 6 to 20:", (string s) => { return true ? s.Length < 20 && s.Length > 5 : false; });
            vehicleProperties.NumberOfWheels = Validated.SetInt("Enter the number of wheels. Input Must be entered in numbers and be less than 50", (wheels) => { return true ? wheels < 50 && wheels >= 0 : false; });
            vehicleProperties.Roof = Validated.SetStringCaseInsesitive("The information about wheter the motorcycle has a roof is mandatory Enter yes or no:", (string s) => { return true ? s == "YES" || s == "NO" : false; });

            Motorcycle motorcycle = new Motorcycle(vehicleProperties);

            return motorcycle;
        }





    }
}